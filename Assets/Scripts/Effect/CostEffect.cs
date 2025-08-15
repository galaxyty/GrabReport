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
        source.UseMP(CostData.Mp);

        Debug.Log("���� MP : " + source.Mp);
    }

    public void SetData(CostData _data)
    {
        CostData = _data;
    }
}
