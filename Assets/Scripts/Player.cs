using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Vector2 m_InputVec2;
    private Vector3 m_MoveDirection;

    [Header("����")]
    [SerializeField]
    private Actor m_Actor;

    [Header("�̵� �ӵ�")]
    [SerializeField]
    private float m_MoveSpeed;

    [Header("�߻� ��ġ�� ��� �� Ʈ������")]
    [SerializeField]
    private Transform m_FireTransform;

    [Header("�׷� ���� �Ҹ� ������")]
    [SerializeField]
    private CostData m_GrabCostData;

    [Header("�׷� ����ü ������")]
    [SerializeField]
    private ProjectileData m_GrabProjectileData;

    [Header("�׷� ������� ������")]
    [SerializeField]
    private PullData m_GrabPullData;

    // �׷�.
    private Grab m_Grab;    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject obj = Resources.Load<GameObject>("Grab");

        // �׷� ����.
        GameObject grab = Instantiate(obj);

        // �׷� ��ũ��Ʈ.
        m_Grab = grab.GetComponent<Grab>();        

        m_Grab.PlayerActor = m_Actor;

        // �׷� ������ ����.
        m_Grab.SetCostData(m_GrabCostData);
        m_Grab.SetProjectileData(m_GrabProjectileData);
        m_Grab.SetPullData(m_GrabPullData);

        // �׷� ��ųȿ�� ����.
        m_Grab.GrabSkill.SetEffect();
    }

    // Update is called once per frame
    void Update()
    {
        // �̵�.
        transform.Translate(m_MoveDirection * m_MoveSpeed * Time.deltaTime);
    }

    // WSAD ������.
    private void OnMove(InputValue value)
    {
        m_InputVec2 = value.Get<Vector2>();
        m_MoveDirection = new Vector3(m_InputVec2.x, 0, m_InputVec2.y);
    }

    // ��Ŭ��.
    private void OnFire()
    {
        m_Grab.transform.localPosition = m_FireTransform.position;
        m_Grab.gameObject.SetActive(true);
        m_Grab.GrabSkill.ApplySkill(m_Actor, null);
    }

    // ���콺 ȸ��.
    private void OnLook(InputValue value)
    {
        Vector2 mousePosition = Mouse.current.position.ReadValue();

        // ��ũ�� ��ǥ�� ���� ��ǥ�� ��ȯ.
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 24.0f));

        Vector3 direction = worldPosition - transform.position;
        direction.y = 0f; // ���� ȸ�� ����

        if (direction != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10f);
        }
    }    
}
