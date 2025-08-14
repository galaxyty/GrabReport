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
        // 시퀀스 개념으로 동작.
        AddEffect(new CostEffect());

        // 투사체에서 시퀀스가 한번 멈추고 다시 재생 시 다음 실행.
        Effect project = new ProjectileEffect();
        project.SetBreak(true);
        AddEffect(project);

        AddEffect(new PullEffect());
    }
}
