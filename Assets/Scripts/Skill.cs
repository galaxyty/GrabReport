using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill
{
    private int m_ListIndex = 0;

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
        // ��� ȿ���� �� ���ƴٸ�.
        if (m_ListIndex >= EffectList.Count)
        {
            m_ListIndex = 0;
            return;
        }

        // ȿ�� ����.
        EffectList[m_ListIndex].Apply(source, target);

        // ȿ�� �������� �߰��� ���ߴ��� Ȯ��.
        if (EffectList[m_ListIndex++].IsBreak == true)
        {            
            return;
        }

        // ���.
        ApplyEffect(source, target);
    }

    public void ResetEffect()
    {
        m_ListIndex = 0;
    }
}
