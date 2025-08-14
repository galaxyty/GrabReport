using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GrabData", menuName = "Scriptable Object/GrabData")]
public class GrabData : ScriptableObject
{
    [Header("�׷� ����ü �ӵ�")]
    [SerializeField]
    public float MoveSpeed;

    [Header("�׷� ��Ÿ�")]
    [SerializeField]
    public float Range;

    [Header("�׷� �����Ҹ�")]
    [SerializeField]
    public float Mp;

    [Header("�׷� ������Ʈ")]
    [SerializeField]
    public GameObject GrabObject;
}
