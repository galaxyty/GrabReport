using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Grab : MonoBehaviour
{
    [Header("그랩 투사체 데이터")]
    [SerializeField]
    private ProjectileData m_GrabProjectileData;

    [Header("그랩 끌어오기 데이터")]
    [SerializeField]
    private PullData m_GrabPullData;

    [SerializeField]
    private Actor m_Actor;  

    // 투사체 발사 스킬 클래스.
    private ProjectileSkill m_ProjectileSkill = new();

    // 끌어오기 스킬 클래스.    
    private PullSkill m_PullSkill = new();

    [HideInInspector]
    public Actor PlayerActor;

    // 투사체 셋팅.
    public void SetData()
    {
        m_ProjectileSkill.SetData(m_GrabProjectileData);
        m_ProjectileSkill.SetEffect();

        m_PullSkill.SetData(m_GrabPullData);
        m_PullSkill.SetEffect();
    }

    private void OnEnable()
    {
        // 정면 방향을 바라보는 곳으로 바꿈.
        transform.forward = PlayerActor.transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        // 투사체 발사 스킬.
        m_ProjectileSkill.ApplySkill(m_Actor, PlayerActor);              
    }

    private void OnCollisionEnter(Collision collision)
    {
        // 임시 방편. 이름으로 확인 시킴
        if (collision.gameObject.name.Equals("EnemyCapsule"))
        {
            m_PullSkill.ApplySkill(PlayerActor, collision.transform.parent.gameObject.GetComponent<Actor>());
            gameObject.SetActive(false);
        }
    }
}
