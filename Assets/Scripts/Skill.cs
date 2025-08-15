using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill
{
    protected List<Effect> EffectList {get;} = new();

    public abstract bool ApplySkill(Actor source, Actor target);

    // 리스트에 효과 추가가 필요해서 만든 함수.
    protected void AddEffect(Effect effect)
    {
        EffectList.Add(effect);
    }

    // 효과 셋팅.
    public abstract void SetEffect();

    public abstract void SetData<T>(T _data);
}
