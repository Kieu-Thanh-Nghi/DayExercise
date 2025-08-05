using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorJumpState : JumpState
{
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        CheckTurn();
        CheckJumpToNextState(animator);
        JumpToIdle(animator);
    }

    protected virtual void CheckJumpToNextState(Animator animator)
    {
        var phy = UniData._physic;
        if (!phy.isFalling && !phy.isUp)
        {
            animator.Play(AnimName.JumpToFall);
        }
    }
}
