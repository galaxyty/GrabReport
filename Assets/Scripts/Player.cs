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

    [Header("�׷� ��ų ������")]
    [SerializeField]
    private GrabData m_GrabData;

    // �׷�.
    private Grab m_Grab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // �׷� ����.
        GameObject grab = Instantiate(m_GrabData.GrabObject);        

        // �׷� ��ũ��Ʈ.
        m_Grab = grab.GetComponent<Grab>();

        // �׷� ��ųȿ�� ����.
        m_Grab.GrabSkill.SetEffect();

        m_Grab.PlayerActor = m_Actor;
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
        m_Grab.GrabSkill.ResetEffect();
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
