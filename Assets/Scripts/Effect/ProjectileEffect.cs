using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 투사체 발사 효과.
public class ProjectileEffect : Effect
{
    // 투사체 데이터.
    private ProjectileData ProjectileData;

    public override void Apply(Actor source, Actor target)
    {
        // 직진 데이터 셋팅.
        source.SetMoveFoward(Vector3.Distance(target.transform.position, source.transform.position), ProjectileData);
    }

    public void SetData(ProjectileData _data)
    {
        ProjectileData = _data;
    }
}
