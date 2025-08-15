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

    [Header("그랩 마나 소모 데이터")]
    [SerializeField]
    private CostData m_GrabCostData;

    // 마나 사용 스킬 클래스.
    private CostSkill m_CostSkill = new CostSkill();

    // 그랩.
    private Grab m_Grab;    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject obj = Resources.Load<GameObject>("Grab");

        // 그랩 생성.
        GameObject grab = Instantiate(obj);

        // 그랩 스크립트.
        m_Grab = grab.GetComponent<Grab>();        

        m_Grab.PlayerActor = m_Actor;

        // 그랩 마나소모 데이터 셋팅.
        m_CostSkill.SetData(m_GrabCostData);

        // 그랩 마나소모 스킬효과 셋팅.
        m_CostSkill.SetEffect();

        // 그랩 투사체 데이터랑 스킬효과 셋팅.
        m_Grab.SetData();
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
        // 그랩 스킬 발동 조건 확인.
        if (m_CostSkill.ApplySkill(m_Actor, null) == true)
        {
            // 조건이 만족되면 스킬을 발동함.
            m_Grab.transform.localPosition = m_FireTransform.position;
            m_Grab.gameObject.SetActive(true);
        }        
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
