using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharDash : CantMoveAct
{
    protected override void OnEnable()
    {
        base.OnEnable();
        animator.Play(AnimName.Dash);
    }

    private void Update()
    {
        if (CheckAnimEnd(AnimName.Dash))
        {
            this.enabled = false;
        }
    }
}
