using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� �Ҹ� ������ ����� ��ų Ŭ����.
public class CostSkill : Skill
{
    // ���� �Ҹ� ������.
    private CostData m_CostData;

    public override bool ApplySkill(Actor source, Actor target)
    {
        // ���� ���ǿ� �����Ͽ� ��ų�� ��� �������� Ȯ��.
        if (m_CostData.Mp >= 2)
        {
            // ��ų ��� ������.
            foreach (Effect effect in EffectList)
            {
                // ���� �Ҹ� ��ų ȿ�� �ߵ�.
                effect.Apply(source, target);
            }

            return true;
        }

        // ��ų ��� ����.
        return false;
    }

    public override void SetEffect()
    {
        // �ڿ� �Ҹ� ȿ�� ����.
        CostEffect costEffect = new();
        costEffect.SetData(m_CostData);
        AddEffect(costEffect);
    }

    public void SetData(CostData _data)
    {
        m_CostData = _data;
    }
}
