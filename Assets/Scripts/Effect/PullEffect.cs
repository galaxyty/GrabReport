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
        //Vector3 toPosition = target.transform.position - source.transform.position;
        //target.PullObject(toPosition.normalized, source.transform.position);

        Debug.Log("끌어당기기");
    }

    public void SetPullData(PullData _data)
    {
        PullData = _data;
    }
}
