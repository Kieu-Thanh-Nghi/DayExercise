using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockState : StateBehavior
{
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (!UniData._inputs.BlockInput())
        {
            animator.SetBool(AnimName.AnimParameter.IsBlocking, false);
        }
    }
}
