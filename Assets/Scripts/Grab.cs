using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Grab : MonoBehaviour
{
    // �׷� ������.
    [Header("�׷� ������")]
    [SerializeField]
    private GrabData m_GrabData;

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

    // Update is called once per frame
    void Update()
    {        
        transform.Translate(-Vector3.back * m_GrabData.MoveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // �ӽ� ����. �̸����� Ȯ�� ��Ŵ
        if (collision.gameObject.name.Equals("EnemyCapsule"))
        {
            m_GrabSkill.ApplySkill(null, null);
        }
    }
}
