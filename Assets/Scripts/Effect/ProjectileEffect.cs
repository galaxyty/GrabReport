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
        // �������� ��.
        //transform.Translate(-Vector3.back * ProjectileData.MoveSpeed * Time.deltaTime);        
    }

    public void SetProjectileData(ProjectileData _data)
    {
        ProjectileData = _data;
    }
}
