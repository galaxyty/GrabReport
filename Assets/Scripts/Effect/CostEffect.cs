using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 자원 소모 효과.
public class CostEffect : Effect
{
    public override void Apply(Actor source, Actor target)
    {
        Debug.Log("자원 소모");
    }
}
