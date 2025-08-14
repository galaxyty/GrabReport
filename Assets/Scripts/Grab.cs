using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Grab : MonoBehaviour
{
    // 그랩 데이터.
    [Header("그랩 데이터")]
    [SerializeField]
    private GrabData m_GrabData;

    // 그랩 스킬 클래스.
    private Skill m_GrabSkill = new GrabSkill();

    public Skill GrabSkill
    {
        get
        {
            return m_GrabSkill;
        }
        private set { }
    }

    public Actor PlayerActor;

    private void OnEnable()
    {
        // 정면 방향을 바라보는 곳으로 바꿈.
        transform.forward = PlayerActor.transform.forward;
    }

    // Update is called once per frame
    void Update()
    {        
        if (Vector3.Distance(PlayerActor.transform.position, transform.position) >= m_GrabData.Distance)
        {
            gameObject.SetActive(false);
            m_GrabSkill.ResetEffect();
        }
        else
        {            
            transform.Translate(-Vector3.back * m_GrabData.MoveSpeed * Time.deltaTime);
        }        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // 임시 방편. 이름으로 확인 시킴
        if (collision.gameObject.name.Equals("EnemyCapsule"))
        {
            m_GrabSkill.ApplySkill(PlayerActor, collision.gameObject.GetComponent<Actor>());
            gameObject.SetActive(false);
        }
    }
}
