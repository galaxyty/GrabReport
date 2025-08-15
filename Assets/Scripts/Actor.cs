using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    // ����.
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

    // ������ ���ΰ�?.
    private bool m_IsPull = false;

    // ����ȯ �� ���� ����.
    private Vector3 m_DirectionNor;

    // Ÿ�� ����.
    private Vector3 m_TargetPos;

    // ������� ��.
    private float m_PullPower;

    // �����ܼ� ���� ���� �Ÿ�.
    private float m_PullStopDistance;

    // ���� �� ���ΰ�?.
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

    // ���� �Լ�.
    private void OnMoveFoward()
    {
        if (m_IsMoveFoward == false)
        {
            return;
        }

        // �������� ��.
        if (m_Distance >= m_ProjectileData.Distance)
        {
            gameObject.SetActive(false);
        }
        else
        {
            transform.Translate(-Vector3.back * m_ProjectileData.MoveSpeed * Time.deltaTime);
        }
    }

    // ������� �Լ�.
    private void OnPullObject()
    {
        if (m_IsPull == true)
        {
            // ������� ������.
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
    /// �����ϴ� ��ų ȿ�� ������ ����.
    /// </summary>
    public void SetMoveFoward(float _distance, ProjectileData _data)
    {
        m_IsMoveFoward = true;
        m_Distance = _distance;
        m_ProjectileData = _data;
    }

    /// <summary>
    /// ������� ��ų ȿ�� ������ ����.
    /// </summary>    
    public void SetPullData(Vector3 _directionNor, Vector3 _targetPos, float _power, float _stopDistance)
    {
        // ���� ������ �̵� ����.
        _directionNor.y = 0.0f;

        // ��� ���� ����, Ÿ�� ��ġ �� ��Ÿ ������ ����.
        m_IsPull = true;
        m_DirectionNor = _directionNor;
        m_TargetPos = _targetPos;
        m_PullPower = _power;
        m_PullStopDistance = _stopDistance;
    }
}
