using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CostData", menuName = "Scriptable Object/CostData")]
public class CostData : ScriptableObject
{
    [Header("���� �Ҹ�")]
    [SerializeField]
    public int Mp;
}
