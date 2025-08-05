using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpState : TurnableStateBehavior
{
    protected Jump jump;
    protected Move move;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
        jump = animator.GetComponent<Jump>();
        move = animator.GetComponent<Move>();
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (UniData._physic.isGround)
        {
            //if(!UniData._physic.isUp)
            animator.Play(AnimName.Idle);
        }
        else
        {
            UniData._inputs.JumpInputDelay();
            base.OnStateUpdate(animator, stateInfo, layerIndex);
        }
    }

    protected virtual void JumpToIdle(Animator animator)
    {
        if (UniData._physic.isGround)
        {
            //if(!UniData._physic.isUp)
            animator.Play(AnimName.Idle);
        }
        else
        {
            UniData._inputs.JumpInputDelay();
        }
    }

    protected override void CheckMeleAttack(Animator animator)
    {
        if (UniData._inputs.MeleAtkInput())
        {
            animator.Play(AnimName.JumpAttack);
        }
    }

    public override void FixedUpdateState()
    {
        move.Going(UniData._inputs.MoveInput());
    }
}
