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
        EffectList[m_ListIndex].Apply(source, target);

        if (EffectList[m_ListIndex++].IsBreak == true)
        {            
            return;
        }

        ApplyEffect(source, target);
    }
}
