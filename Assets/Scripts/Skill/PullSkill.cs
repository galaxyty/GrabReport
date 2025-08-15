using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 끌어오기 스킬.
public class PullSkill : Skill
{
    // 끌어오는 데이터.
    private PullData m_PullData;

    public override bool ApplySkill(Actor source, Actor target)
    {
        foreach (Effect effect in EffectList)
        {
            effect.Apply(source, target);
        }

        return true;              
    }

    public override void SetEffect()
    {
        // 끌어오는 효과 셋팅.
        PullEffect pullEffect = new();
        pullEffect.SetData(m_PullData);
        AddEffect(pullEffect);
    }

    public void SetData(PullData _data)
    {
        m_PullData = _data;
    }
}
