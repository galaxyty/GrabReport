using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����ü �߻� ȿ��.
public class ProjectileEffect : Effect
{
    public override void Apply(Actor source, Actor target)
    {
        Debug.Log("����ü �߻�");
    }
}
