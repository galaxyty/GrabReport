using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ProjectileData", menuName = "Scriptable Object/ProjectileData")]
public class ProjectileData : ScriptableObject
{
    [Header("그랩 투사체 속도")]
    [SerializeField]
    public float MoveSpeed;

    [Header("그랩 사거리")]
    [SerializeField]
    public float Distance;
}
