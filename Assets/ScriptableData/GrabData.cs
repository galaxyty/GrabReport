using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GrabData", menuName = "Scriptable Object/GrabData")]
public class GrabData : ScriptableObject
{
    [Header("그랩 투사체 속도")]
    [SerializeField]
    public float MoveSpeed;

    [Header("그랩 사거리")]
    [SerializeField]
    public float Range;

    [Header("그랩 마나소모량")]
    [SerializeField]
    public float Mp;

    [Header("그랩 오브젝트")]
    [SerializeField]
    public GameObject GrabObject;
}
