using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : GroundState
{
    protected override void CheckGround(Animator animator)
    {
        toWalkState(animator);
        base.CheckGround(animator);
    }

    protected virtual void toWalkState(Animator animator)
    {
        if (Mathf.Abs(UniData._inputs.MoveInput()) > 0.1)
        {
            animator.Play(AnimName.Walk);
        }
    }
}
