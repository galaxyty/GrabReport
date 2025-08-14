using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Effect
{    
    // 브레이크 판별용 bool 변수.
    public bool IsBreak = false;

    public virtual void SetBreak(bool _isBreak)
    {
        IsBreak = _isBreak;
    }

    public abstract void Apply(Actor source, Actor target);
}
