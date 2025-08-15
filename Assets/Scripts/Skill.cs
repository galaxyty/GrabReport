using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill
{
    protected List<Effect> EffectList {get;} = new();

    public abstract bool ApplySkill(Actor source, Actor target);

    // ����Ʈ�� ȿ�� �߰��� �ʿ��ؼ� ���� �Լ�.
    protected void AddEffect(Effect effect)
    {
        EffectList.Add(effect);
    }

    // ȿ�� ����.
    public abstract void SetEffect();

    public abstract void SetData<T>(T _data);
}
