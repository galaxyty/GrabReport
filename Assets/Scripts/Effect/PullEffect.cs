using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ²ø¾î¿À±â È¿°ú.
public class PullEffect : Effect
{    
    public override void Apply(Actor source, Actor target)
    {
        Vector3 toPosition = target.transform.position - source.transform.position;
        target.PullObject(toPosition.normalized, source.transform.position);

        Debug.Log("²ø¾î¿À±â");
    }
}
