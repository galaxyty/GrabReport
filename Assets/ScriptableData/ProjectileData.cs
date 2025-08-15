using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ProjectileData", menuName = "Scriptable Object/ProjectileData")]
public class ProjectileData : ScriptableObject
{
    [Header("투사체 속도")]
    [SerializeField]
    public float MoveSpeed;

    [Header("사거리")]
    [SerializeField]
    public float Distance;
}
