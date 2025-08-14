using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill
{
    private List<Effect> EffectList {get;} = new();

    public abstract bool ApplySkill(Actor source, Actor target);

    // ����Ʈ�� ȿ�� �߰��� �ʿ��ؼ� ���� �Լ�.
    protected void AddEffect(Effect effect)
    {
        EffectList.Add(effect);
    }

    // ȿ�� ����.
    public abstract void SetEffect();

    // ��ų ȿ�� ���.
    protected void ApplyEffect(Actor source, Actor target)
    {
        foreach (Effect effect in EffectList)
        {
            effect.Apply(source, target);
        }
    }
}
