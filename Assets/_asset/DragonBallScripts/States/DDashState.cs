using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDashState : DCantMoveState
{
    protected override StatesName thisStateName => StatesName.Dash;

    protected override void DoWhenInState(Animator animator)
    {
        if (!_data._inputs.DashInput()) { 
            animator.SetBool(AnimName.Dash, false);
        } 
    }
}
