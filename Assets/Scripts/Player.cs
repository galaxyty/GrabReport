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
}
