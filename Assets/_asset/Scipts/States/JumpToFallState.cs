using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpToFallState : WarriorJumpState
{
    protected override void CheckJumpToNextState(Animator animator)
    {
        ToFallState(animator);
    }
    protected virtual void ToFallState(Animator animator)
    {
        if (UniData._physic.isFalling)
        {
            animator.SetTrigger(AnimName.AnimParameter.FallTrigger);
        }
    }
}
