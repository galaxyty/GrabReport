using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �ڿ� �Ҹ� ȿ��.
public class CostEffect : Effect
{
    // ���� �Ҹ� ������.
    private CostData CostData;

    public override void Apply(Actor source, Actor target)
    {
        Debug.Log("���� MP : " + source.Mp);
    }

    public void SetCostData(CostData _data)
    {
        CostData = _data;
    }
}
