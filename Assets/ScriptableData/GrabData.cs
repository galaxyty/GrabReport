using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GrabData", menuName = "Scriptable Object/GrabData")]
public class GrabData : ScriptableObject
{
    [Header("±×·¦ Åõ»çÃ¼ ¼Óµµ")]
    [SerializeField]
    public float MoveSpeed;

    [Header("±×·¦ »ç°Å¸®")]
    [SerializeField]
    public float Distance;

    [Header("±×·¦ ¸¶³ª¼Ò¸ð·®")]
    [SerializeField]
    public int Mp;

    [Header("±×·¦ ²ø¾î ´ç±â´Â Èû")]
    [SerializeField]
    public float Power;

    [Header("±×·¦ ´ë»ó ¸ØÃß´Â °Å¸®")]
    [SerializeField]
    public float StopDistance;

    [Header("±×·¦ ¿ÀºêÁ§Æ®")]
    [SerializeField]
    public GameObject GrabObject;
}
