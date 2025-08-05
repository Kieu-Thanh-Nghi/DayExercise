using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundState : TurnableStateBehavior
{
    public override void FixedUpdateState()
    {
        
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateUpdate(animator, stateInfo, layerIndex);
        bool isGround = UniData._physic.isGround;
        if (isGround)
        {
            CheckGround(animator);
        }
        else
        {
            CheckNotGround(animator);
        }
    }

    protected virtual void CheckGround(Animator animator)
    {
        toJumpState(animator);
        toCrouchState(animator);
    }    
    
    protected virtual void CheckNotGround(Animator animator)
    {
        animator.Play(AnimName.Jump);
    }
    protected virtual void toJumpState(Animator animator)
    {
        if (UniData._inputs.JumpInput())
        {
            UniData._animator.GetComponent<Jump>().JumpUp();
            animator.Play(AnimName.Jump);
        }
    }

    protected virtual void toCrouchState(Animator animator)
    {
        if (UniData._inputs.DownInput())
        {
            animator.Play(AnimName.Crouch);
        }
    }
}
