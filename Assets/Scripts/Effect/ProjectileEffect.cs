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
        // 정면으로 감.
        if (Vector3.Distance(target.transform.position, source.transform.position) >= ProjectileData.Distance)
        {
            source.gameObject.SetActive(false);
        }
        else
        {
            source.transform.Translate(-Vector3.back * ProjectileData.MoveSpeed * Time.deltaTime);
        }
    }

    public void SetData(ProjectileData _data)
    {
        ProjectileData = _data;
    }
}
