using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBlockState : DState
{
    protected override StatesName thisStateName => StatesName.Block;

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (!_data._inputs.BlockInput()) animator.SetBool(AnimName.Block, false);
    }
}
