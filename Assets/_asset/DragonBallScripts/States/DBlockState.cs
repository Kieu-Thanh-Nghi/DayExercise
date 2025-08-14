using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBlockState : DCantMoveState
{
    protected override StatesName thisStateName => StatesName.Block;

    protected override void DoWhenInState(Animator animator)
    {
        if (!_data._inputs.BlockInput()) animator.SetBool(AnimName.Block, false);
    }
}
