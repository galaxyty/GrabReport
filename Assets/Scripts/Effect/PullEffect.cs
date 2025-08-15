using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ������� ȿ��.
public class PullEffect : Effect
{
    // ������� ������.
    private PullData PullData;

    public override void Apply(Actor source, Actor target)
    {        
        // Ÿ�� ��󿡰� ������ ��ġ ���Ϳ� �� �� ��Ÿ �����͸� ����.
        Vector3 toPosition = target.transform.position - source.transform.position;
        target.SetPullData(toPosition.normalized, source.transform.position, PullData.Power, PullData.StopDistance);        
    }

    public void SetData(PullData _data)
    {
        PullData = _data;
    }
}
