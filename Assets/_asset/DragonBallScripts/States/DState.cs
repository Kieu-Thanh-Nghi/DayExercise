using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DState : StateMachineBehaviour
{
    protected UniformStatesData _data;

    protected bool isInState = false;
    protected abstract StatesName thisStateName { get; }

    public virtual void SetUp(UniformStatesData data)
    {
        _data = data;
    }
}
