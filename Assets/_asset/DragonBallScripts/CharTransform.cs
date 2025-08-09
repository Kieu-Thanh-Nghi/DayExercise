using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharTransform : CantMoveAct
{
    public int TimeTransform;
    protected override void OnEnable()
    {
        base.OnEnable();
        animator.Play(AnimName.PreTransform);
    }

    private void Update()
    {
        if (CheckAnimEnd(AnimName.CharTransform))
        {
            this.enabled = false;
        }
    }
}
