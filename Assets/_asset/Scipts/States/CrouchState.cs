using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchState : TurnableStateBehavior
{
    protected override void CheckAllAtkActions(Animator animator)
    {
        if (UniData._inputs.RangeAttackInput())
        {
            animator.SetTrigger(AnimName.AnimParameter.AtkTrigger);
        }
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateUpdate(animator, stateInfo, layerIndex);
        CrouchToIdle(animator);
    }

    protected virtual void CrouchToIdle(Animator animator)
    {
        if (!UniData._inputs.DownInput())
        {
            animator.Play(AnimName.Idle);
        }
    }
}
