using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PullData", menuName = "Scriptable Object/PullData")]
public class PullData : ScriptableObject
{
    [Header("²ø¾î ´ç±â´Â Èû")]
    [SerializeField]
    public float Power;

    [Header("²ø¾î ´ç±â´Â ´ë»ó ¸ØÃß´Â °Å¸®")]
    [SerializeField]
    public float StopDistance;
}
