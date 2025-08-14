using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    private int m_Mp = 100;

    public int Mp
    {
        get
        {
            return m_Mp;
        }
        set
        {
            m_Mp = value;
        }
    }

    private bool m_IsPull = false;

    private Vector3 m_Vec3;

    private Vector3 m_Pos;

    public void ApplySkill(Actor target)
    {
        
    }

    private void Update()
    {
        //if (m_IsPull == true)
        //{
        //    if (Vector3.Distance(transform.position, m_Pos) <= m_GrabData.StopDistance)
        //    {
        //        m_IsPull = false;
        //    }
        //    else
        //    {
        //        transform.position -= m_Vec3 * m_GrabData.Power * Time.deltaTime;
        //    }            
        //}
    }

    public void PullObject(Vector3 _vec3, Vector3 _targetPos)
    {
        _vec3.y = 0.0f;
        m_IsPull = true;
        m_Vec3 = _vec3;
        m_Pos = _targetPos;
    }
}
