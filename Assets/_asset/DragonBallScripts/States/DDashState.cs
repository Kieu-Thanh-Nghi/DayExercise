using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDashState : DState
{
    protected override StatesName thisStateName => StatesName.Dash;

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (!_data._inputs.BlockInput()) animator.SetBool(AnimName.Dash, false);
    }
}
