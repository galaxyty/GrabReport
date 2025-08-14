using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabSkill : Skill
{
    // �׷� ���� �Ҹ� ������.
    private CostData m_GrabCostData;

    // �׷� ����ü ������.
    private ProjectileData m_GrabProjectileData;

    // �׷� ����ü ������.
    private PullData m_GrabPullData;

    // ��ų ���
    public override bool ApplySkill(Actor source, Actor target)
    {
        foreach (Effect effect in EffectList)
        {
            effect.Apply(source, target);
        }        

        return true;
    }

    // ��ų ȿ�� ����.
    public override void SetEffect()
    {
        // �ڿ� �Ҹ� -> ����ü �߻� -> �������.

        // �ڿ� �Ҹ� ȿ�� ����.
        CostEffect costEffect = new();
        costEffect.SetCostData(m_GrabCostData);
        AddEffect(costEffect);

        // ����ü ����.
        ProjectileEffect projectileEffect = new();
        projectileEffect.SetProjectileData(m_GrabProjectileData);
        AddEffect(projectileEffect);

        // ������� ����.
        PullEffect pullEffect = new();
        pullEffect.SetPullData(m_GrabPullData);
        AddEffect(pullEffect);
    }

    public void SetCostData(CostData _data)
    {
        m_GrabCostData = _data;
    }

    public void SetProjectileData(ProjectileData _data)
    {
        m_GrabProjectileData = _data;
    }

    public void SetPullData(PullData _data)
    {
        m_GrabPullData = _data;
    }
}
