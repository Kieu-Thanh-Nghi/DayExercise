using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiBlastSM : NoMoveStateMachine
{
    int BlastIndex = 0;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
        BlastIndex = 1 - BlastIndex;
        animator.SetInteger(AnimName.KiBlast, BlastIndex + 1);
    }
}
