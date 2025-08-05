using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkState : GroundState
{
    protected Move move;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
        move = animator.GetComponent<Move>();
    }
    public override void FixedUpdateState()
    {
        moveCharacter();
    }

    private void moveCharacter()
    {
        move.Going(Input.GetAxis("Horizontal"));
    }

    protected override void CheckGround(Animator animator)
    {
        WalktoIdle(animator);
        base.CheckGround(animator);
    }

    protected virtual void WalktoIdle(Animator animator)
    {
        if (Mathf.Abs(UniData._inputs.MoveInput()) < 0.1)
        {
            animator.Play(AnimName.Idle);
        }
    }
}
