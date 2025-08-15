using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Grab : MonoBehaviour
{
    [Header("�׷� ����ü ������")]
    [SerializeField]
    private ProjectileData m_GrabProjectileData;

    [Header("�׷� ������� ������")]
    [SerializeField]
    private PullData m_GrabPullData;

    [SerializeField]
    private Actor m_Actor;  

    // ����ü �߻� ��ų Ŭ����.
    private ProjectileSkill m_ProjectileSkill = new();

    // ������� ��ų Ŭ����.    
    private PullSkill m_PullSkill = new();

    [HideInInspector]
    public Actor PlayerActor;

    // ����ü ����.
    public void SetData()
    {
        m_ProjectileSkill.SetData(m_GrabProjectileData);
        m_ProjectileSkill.SetEffect();

        m_PullSkill.SetData(m_GrabPullData);
        m_PullSkill.SetEffect();
    }

    private void OnEnable()
    {
        // ���� ������ �ٶ󺸴� ������ �ٲ�.
        transform.forward = PlayerActor.transform.forward;
    }

    // Update is called once per frame
    void Update()
    {
        // ����ü �߻� ��ų.
        m_ProjectileSkill.ApplySkill(m_Actor, PlayerActor);              
    }

    private void OnCollisionEnter(Collision collision)
    {
        // �ӽ� ����. �̸����� Ȯ�� ��Ŵ
        if (collision.gameObject.name.Equals("EnemyCapsule"))
        {
            m_PullSkill.ApplySkill(PlayerActor, collision.transform.parent.gameObject.GetComponent<Actor>());
            gameObject.SetActive(false);
        }
    }
}
