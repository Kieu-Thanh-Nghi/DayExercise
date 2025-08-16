using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterCtrler : AloneState
{
    protected override void OnEnable()
    {
        base.OnEnable();
        animHandle.PlayCounter(1);
    }

    private void Update()
    {
        
    }
}
