using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiBastCtrler : AloneState
{
    protected override void OnEnable()
    {
        base.OnEnable();
        animHandle.PlayKiBlast();
    }

    private void Update()
    {
        if(animHandle.PlayKiBlast(CheckKiBlastAnimEnd: true))
        {
            this.enabled = false;
        }
    }
}
