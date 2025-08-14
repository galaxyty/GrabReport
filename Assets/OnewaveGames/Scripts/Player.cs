using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Vector2 inputVec2;
    private Vector3 moveDirection;

    [Header("�̵� �ӵ�")]
    [SerializeField]
    private float m_MoveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveDirection * m_MoveSpeed * Time.deltaTime);
    }

    // WSAD ������.
    private void OnMove(InputValue value)
    {
        inputVec2 = value.Get<Vector2>();
        moveDirection = new Vector3(inputVec2.x, 0, inputVec2.y);
    }

    // ��Ŭ��.
    private void OnFire()
    {
        Debug.Log("asd");
    }
}
