using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullSkill : Skill
{
    // ����ü ������.
    private PullData m_PullData;

    public override bool ApplySkill(Actor source, Actor target)
    {
        Debug.Log("������� : " + m_PullData.StopDistance);
        return true;
    }

    public override void SetEffect()
    {
        // ����ü ȿ�� ����.
        PullEffect pullEffect = new();
        pullEffect.SetData(m_PullData);
        AddEffect(pullEffect);
    }

    public void SetData(PullData _data)
    {
        m_PullData = _data;
    }
}
