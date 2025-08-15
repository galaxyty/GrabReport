using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSkill : Skill
{
    // 투사체 데이터.
    private ProjectileData m_ProjectileData;

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
        // 투사체 효과 셋팅.
        ProjectileEffect projectEffect = new();
        projectEffect.SetData(m_ProjectileData);
        AddEffect(projectEffect);
    }

    public void SetData(ProjectileData _data)
    {
        m_ProjectileData = _data;
    }
}
