using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill
{
    private int m_ListIndex = 0;

    private List<Effect> EffectList {get;} = new();

    public abstract bool ApplySkill(Actor source, Actor target);

    // 리스트에 효과 추가가 필요해서 만든 함수.
    protected void AddEffect(Effect effect)
    {
        EffectList.Add(effect);
    }

    // 효과 셋팅.
    public abstract void SetEffect();

    // 스킬 효과 사용.
    protected void ApplyEffect(Actor source, Actor target)
    {
        // 모든 효과를 다 거쳤다면.
        if (m_ListIndex >= EffectList.Count)
        {
            m_ListIndex = 0;
            return;
        }

        // 효과 실행.
        EffectList[m_ListIndex].Apply(source, target);

        // 효과 시퀀스가 중간에 멈추는지 확인.
        if (EffectList[m_ListIndex++].IsBreak == true)
        {            
            return;
        }

        // 재귀.
        ApplyEffect(source, target);
    }

    public void ResetEffect()
    {
        m_ListIndex = 0;
    }
}
