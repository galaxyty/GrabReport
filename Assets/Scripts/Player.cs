using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Vector2 m_InputVec2;
    private Vector3 m_MoveDirection;

    [Header("액터")]
    [SerializeField]
    private Actor m_Actor;

    [Header("이동 속도")]
    [SerializeField]
    private float m_MoveSpeed;

    [Header("발사 위치로 사용 할 트랜스폼")]
    [SerializeField]
    private Transform m_FireTransform;

    [Header("그랩 스킬 데이터")]
    [SerializeField]
    private GrabData m_GrabData;

    // 그랩.
    private Grab m_Grab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 그랩 생성.
        GameObject grab = Instantiate(m_GrabData.GrabObject);        

        // 그랩 스크립트.
        m_Grab = grab.GetComponent<Grab>();

        // 그랩 스킬효과 셋팅.
        m_Grab.GrabSkill.SetEffect();

        m_Grab.PlayerActor = m_Actor;
    }

    // Update is called once per frame
    void Update()
    {
        // 이동.
        transform.Translate(m_MoveDirection * m_MoveSpeed * Time.deltaTime);
    }

    // WSAD 움직임.
    private void OnMove(InputValue value)
    {
        m_InputVec2 = value.Get<Vector2>();
        m_MoveDirection = new Vector3(m_InputVec2.x, 0, m_InputVec2.y);
    }

    // 좌클릭.
    private void OnFire()
    {
        m_Grab.transform.localPosition = m_FireTransform.position;
        m_Grab.gameObject.SetActive(true);
        m_Grab.GrabSkill.ResetEffect();
        m_Grab.GrabSkill.ApplySkill(m_Actor, null);
    }

    // 마우스 회전.
    private void OnLook(InputValue value)
    {
        Vector2 mousePosition = Mouse.current.position.ReadValue();

        // 스크린 좌표를 월드 좌표로 변환.
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 24.0f));

        Vector3 direction = worldPosition - transform.position;
        direction.y = 0f; // 수직 회전 방지

        if (direction != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10f);
        }
    }    
}
