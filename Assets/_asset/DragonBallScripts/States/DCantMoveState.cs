using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DCantMoveState : DState
{
    protected override void DoWhenEnter(Animator animator)
    {
        base.DoWhenEnter(animator);
        _data._charController.enabled = false;
        _data._moveControl.enabled = false;
        animator.SetInteger(AnimName.Move, -1);
    }
}
