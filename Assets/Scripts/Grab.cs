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

    // Update is called once per frame
    void Update()
    {        
        transform.Translate(-Vector3.back * m_GrabData.MoveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // 임시 방편. 이름으로 확인 시킴
        if (collision.gameObject.name.Equals("EnemyCapsule"))
        {
            m_GrabSkill.ApplySkill(null, null);
        }
    }
}
