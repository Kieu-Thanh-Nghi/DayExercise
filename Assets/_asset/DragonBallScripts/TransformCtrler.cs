using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformCtrler : AloneState
{
    protected override void OnEnable()
    {
        base.OnEnable();
        animHandle.PlayTransform();
    }

    private void Update()
    {
        if (animHandle.PlayTransform(CheckAnimEnd: true))
        {
            this.enabled = false;
        }
    }
}
