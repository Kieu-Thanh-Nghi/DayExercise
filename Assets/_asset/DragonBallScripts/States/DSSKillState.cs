using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DSSKillState : DCantMoveState
{
    protected override StatesName thisStateName => StatesName.SpecialSkill;

    protected override void DoWhenInState(Animator animator){}
}
