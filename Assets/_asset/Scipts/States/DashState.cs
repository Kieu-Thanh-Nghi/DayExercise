using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashState : StateBehavior
{
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (UniData._inputs.MeleAtkInput())
        {
            animator.Play(AnimName.DashAttack);
        }
    }
}
