using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DKiBlastState : DState
{
    public int index;
    protected override StatesName thisStateName => throw new System.NotImplementedException();

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        index = 1 - index;
        animator.SetInteger(AnimName.KiBlast, -1);
    }
}
