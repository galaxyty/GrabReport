using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Grab : MonoBehaviour
{    
    // �׷� ��ų Ŭ����.
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

    public void SetCostData(CostData _data)
    {
        GrabSkill grabSkill = m_GrabSkill as GrabSkill;
        grabSkill.SetCostData(_data);
    }

    public void SetProjectileData(ProjectileData _data)
    {
        GrabSkill grabSkill = m_GrabSkill as GrabSkill;
        grabSkill.SetProjectileData(_data);
    }

    public void SetPullData(PullData _data)
    {
        GrabSkill grabSkill = m_GrabSkill as GrabSkill;
        grabSkill.SetPullData(_data);
    }

    private void OnEnable()
    {
        // ���� ������ �ٶ󺸴� ������ �ٲ�.
        transform.forward = PlayerActor.transform.forward;
    }

    // Update is called once per frame
    void Update()
    {        
        //if (Vector3.Distance(PlayerActor.transform.position, transform.position) >= m_GrabData.Distance)
        //{
        //    gameObject.SetActive(false);
        //}
        //else
        //{            
        //    transform.Translate(-Vector3.back * m_GrabData.MoveSpeed * Time.deltaTime);
        //}        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // �ӽ� ����. �̸����� Ȯ�� ��Ŵ
        if (collision.gameObject.name.Equals("EnemyCapsule"))
        {
            m_GrabSkill.ApplySkill(PlayerActor, collision.gameObject.GetComponent<Actor>());
            gameObject.SetActive(false);
        }
    }
}
