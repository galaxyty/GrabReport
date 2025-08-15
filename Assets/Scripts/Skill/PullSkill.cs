using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullSkill : Skill
{
    // 투사체 데이터.
    private PullData m_PullData;

    public override bool ApplySkill(Actor source, Actor target)
    {
        Debug.Log("끌어오기 : " + m_PullData.StopDistance);
        return true;
    }

    public override void SetEffect()
    {
        // 투사체 효과 셋팅.
        PullEffect pullEffect = new();
        pullEffect.SetData(m_PullData);
        AddEffect(pullEffect);
    }

    public void SetData(PullData _data)
    {
        m_PullData = _data;
    }
}
