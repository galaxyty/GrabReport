using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 마나 소모 역할을 담당할 스킬 클래스.
public class CostSkill : Skill
{
    // 마나 소모 데이터.
    private CostData m_CostData;

    public override bool ApplySkill(Actor source, Actor target)
    {
        // 마나 조건에 만족하여 스킬이 사용 가능한지 확인.
        if (m_CostData.Mp >= 2)
        {
            // 스킬 사용 가능함.
            foreach (Effect effect in EffectList)
            {
                // 마나 소모 스킬 효과 발동.
                effect.Apply(source, target);
            }

            return true;
        }

        // 스킬 사용 실패.
        return false;
    }

    public override void SetEffect()
    {
        // 자원 소모 효과 셋팅.
        CostEffect costEffect = new();
        costEffect.SetData(m_CostData);
        AddEffect(costEffect);
    }

    public void SetData(CostData _data)
    {
        m_CostData = _data;
    }
}
