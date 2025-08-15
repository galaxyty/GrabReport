using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������� ��ų.
public class PullSkill : Skill
{
    // ������� ������.
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
        // ������� ȿ�� ����.
        PullEffect pullEffect = new();
        pullEffect.SetData(m_PullData);
        AddEffect(pullEffect);
    }

    public void SetData(PullData _data)
    {
        m_PullData = _data;
    }
}
