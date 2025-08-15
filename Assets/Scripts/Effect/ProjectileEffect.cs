using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����ü �߻� ȿ��.
public class ProjectileEffect : Effect
{
    // ����ü ������.
    private ProjectileData ProjectileData;

    public override void Apply(Actor source, Actor target)
    {
        // ���� ������ ����.
        source.SetMoveFoward(Vector3.Distance(target.transform.position, source.transform.position), ProjectileData);
    }

    public void SetData(ProjectileData _data)
    {
        ProjectileData = _data;
    }
}
