using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSkill : Skill
{
    // ����ü ������.
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
        // ����ü ȿ�� ����.
        ProjectileEffect projectEffect = new();
        projectEffect.SetData(m_ProjectileData);
        AddEffect(projectEffect);
    }

    public void SetData(ProjectileData _data)
    {
        m_ProjectileData = _data;
    }
}
