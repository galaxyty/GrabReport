using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabSkill : Skill
{
    // 그랩 마나 소모 데이터.
    private CostData m_GrabCostData;

    // 그랩 투사체 데이터.
    private ProjectileData m_GrabProjectileData;

    // 그랩 투사체 데이터.
    private PullData m_GrabPullData;

    // 스킬 사용
    public override bool ApplySkill(Actor source, Actor target)
    {
        foreach (Effect effect in EffectList)
        {
            effect.Apply(source, target);
        }        

        return true;
    }

    // 스킬 효과 셋팅.
    public override void SetEffect()
    {
        // 자원 소모 -> 투사체 발사 -> 끌어오기.

        // 자원 소모 효과 셋팅.
        CostEffect costEffect = new();
        costEffect.SetCostData(m_GrabCostData);
        AddEffect(costEffect);

        // 투사체 셋팅.
        ProjectileEffect projectileEffect = new();
        projectileEffect.SetProjectileData(m_GrabProjectileData);
        AddEffect(projectileEffect);

        // 끌어오기 셋팅.
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
