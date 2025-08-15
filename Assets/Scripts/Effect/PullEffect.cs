using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 끌어오기 효과.
public class PullEffect : Effect
{
    // 끌어당기는 데이터.
    private PullData PullData;

    public override void Apply(Actor source, Actor target)
    {        
        Vector3 toPosition = target.transform.position - source.transform.position;
        target.SetPullObject(toPosition.normalized, source.transform.position, PullData.Power, PullData.StopDistance);        
    }

    public void SetData(PullData _data)
    {
        PullData = _data;
    }
}
