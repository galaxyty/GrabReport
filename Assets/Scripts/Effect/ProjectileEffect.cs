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
        if (Vector3.Distance(target.transform.position, source.transform.position) >= ProjectileData.Distance)
        {
            source.gameObject.SetActive(false);
        }
        else
        {
            source.transform.Translate(-Vector3.back * ProjectileData.MoveSpeed * Time.deltaTime);
        }
    }

    public void SetData(ProjectileData _data)
    {
        ProjectileData = _data;
    }
}
