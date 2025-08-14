using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Effect
{    
    // �극��ũ �Ǻ��� bool ����.
    public bool IsBreak = false;

    public virtual void SetBreak(bool _isBreak)
    {
        IsBreak = _isBreak;
    }

    public abstract void Apply(Actor source, Actor target);
}
