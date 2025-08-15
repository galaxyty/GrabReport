using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 자원 소모 효과.
public class CostEffect : Effect
{
    // 마나 소모 데이터.
    private CostData CostData;

    public override void Apply(Actor source, Actor target)
    {
        source.UseMP(CostData.Mp);

        Debug.Log("남은 MP : " + source.Mp);
    }

    public void SetData(CostData _data)
    {
        CostData = _data;
    }
}
