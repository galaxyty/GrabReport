using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    // 마나.
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

    // 끌어당길 것인가?.
    private bool m_IsPull = false;

    // 정규환 된 방향 벡터.
    private Vector3 m_DirectionNor;

    // 타겟 벡터.
    private Vector3 m_TargetPos;

    // 끌어당기는 힘.
    private float m_PullPower;

    // 끌어당겨서 대상과 멈출 거리.
    private float m_PullStopDistance;

    // 직진 할 것인가?.
    private bool m_IsMoveFoward = false;

    private float m_Distance;

    ProjectileData m_ProjectileData;

    public void ApplySkill(Actor target)
    {
        
    }

    private void Update()
    {
        OnPullObject();
        OnMoveFoward();
    }

    // 직진 함수.
    private void OnMoveFoward()
    {
        if (m_IsMoveFoward == false)
        {
            return;
        }

        // 정면으로 감.
        if (m_Distance >= m_ProjectileData.Distance)
        {
            gameObject.SetActive(false);
        }
        else
        {
            transform.Translate(-Vector3.back * m_ProjectileData.MoveSpeed * Time.deltaTime);
        }
    }

    // 끌어당기는 함수.
    private void OnPullObject()
    {
        if (m_IsPull == true)
        {
            // 대상으로 끌어당김.
            if (Vector3.Distance(transform.position, m_TargetPos) <= m_PullStopDistance)
            {
                m_IsPull = false;
            }
            else
            {
                transform.position -= m_DirectionNor * m_PullPower * Time.deltaTime;
            }
        }
    }

    /// <summary>
    /// 직진하는 스킬 효과 데이터 세팅.
    /// </summary>
    public void SetMoveFoward(float _distance, ProjectileData _data)
    {
        m_IsMoveFoward = true;
        m_Distance = _distance;
        m_ProjectileData = _data;
    }

    /// <summary>
    /// 끌어당기는 스킬 효과 데이터 세팅.
    /// </summary>    
    public void SetPullData(Vector3 _directionNor, Vector3 _targetPos, float _power, float _stopDistance)
    {
        // 수직 방향은 이동 안함.
        _directionNor.y = 0.0f;

        // 끌어갈 방향 벡터, 타겟 위치 등 기타 데이터 셋팅.
        m_IsPull = true;
        m_DirectionNor = _directionNor;
        m_TargetPos = _targetPos;
        m_PullPower = _power;
        m_PullStopDistance = _stopDistance;
    }
}
