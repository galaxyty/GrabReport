using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 투사체 발사 효과.
public class ProjectileEffect : Effect
{
    public override void Apply(Actor source, Actor target)
    {
        Debug.Log("투사체 발사");
    }
}
