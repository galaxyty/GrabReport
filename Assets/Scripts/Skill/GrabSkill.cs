using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabSkill : Skill
{    
    // 스킬 사용
    public override bool ApplySkill(Actor source, Actor target)
    {
        ApplyEffect(source, target);
        return true;
    }

    // 스킬 효과 셋팅.
    public override void SetEffect()
    {
        // 자원 소모 -> 투사체 발사 -> 끌어오기.
        AddEffect(new CostEffect());
        AddEffect(new ProjectileEffect());
        AddEffect(new PullEffect());
    }
}
