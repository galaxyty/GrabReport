using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private Vector2 inputVec2;
    private Vector3 moveDirection;

    [Header("이동 속도")]
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

    // WSAD 움직임.
    private void OnMove(InputValue value)
    {
        inputVec2 = value.Get<Vector2>();
        moveDirection = new Vector3(inputVec2.x, 0, inputVec2.y);
    }

    // 좌클릭.
    private void OnFire()
    {
        Debug.Log("asd");
    }
}
