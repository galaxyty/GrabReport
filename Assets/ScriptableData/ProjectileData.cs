using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ProjectileData", menuName = "Scriptable Object/ProjectileData")]
public class ProjectileData : ScriptableObject
{
    [Header("����ü �ӵ�")]
    [SerializeField]
    public float MoveSpeed;

    [Header("��Ÿ�")]
    [SerializeField]
    public float Distance;
}
