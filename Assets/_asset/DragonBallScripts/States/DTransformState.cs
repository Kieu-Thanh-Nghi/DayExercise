using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DTransformState : DCantMoveState
{
    protected override StatesName thisStateName => StatesName.Transform;

    protected override void DoWhenInState(Animator animator){}
}
