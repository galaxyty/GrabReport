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
    public float Distance;

    [Header("�׷� �����Ҹ�")]
    [SerializeField]
    public int Mp;

    [Header("�׷� ���� ���� ��")]
    [SerializeField]
    public float Power;

    [Header("�׷� ��� ���ߴ� �Ÿ�")]
    [SerializeField]
    public float StopDistance;

    [Header("�׷� ������Ʈ")]
    [SerializeField]
    public GameObject GrabObject;
}
