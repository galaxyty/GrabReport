using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CostData", menuName = "Scriptable Object/CostData")]
public class CostData : ScriptableObject
{
    [Header("마나 소모량")]
    [SerializeField]
    public int Mp;
}
