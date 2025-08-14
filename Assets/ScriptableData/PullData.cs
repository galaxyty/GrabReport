using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PullData", menuName = "Scriptable Object/PullData")]
public class PullData : ScriptableObject
{
    [Header("���� ���� ��")]
    [SerializeField]
    public float Power;

    [Header("���� ���� ��� ���ߴ� �Ÿ�")]
    [SerializeField]
    public float StopDistance;
}
