using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabSkill : Skill
{    
    // ��ų ���
    public override bool ApplySkill(Actor source, Actor target)
    {
        ApplyEffect(source, target);
        return true;
    }

    // ��ų ȿ�� ����.
    public override void SetEffect()
    {
        // �ڿ� �Ҹ� -> ����ü �߻� -> �������.
        AddEffect(new CostEffect());
        AddEffect(new ProjectileEffect());
        AddEffect(new PullEffect());
    }
}
