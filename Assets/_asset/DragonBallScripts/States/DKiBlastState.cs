using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DKiBlastState : DCantMoveState
{
    public int index;
    protected override StatesName thisStateName => StatesName.KiBlast;

    protected override void DoWhenEnter(Animator animator)
    {
        base.DoWhenEnter(animator);
        index = 1 - index;
        animator.SetInteger(AnimName.KiBlast, -1);
    }

    protected override void DoWhenInState(Animator animator){}
}
