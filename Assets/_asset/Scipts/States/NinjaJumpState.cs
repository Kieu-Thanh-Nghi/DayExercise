using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaJumpState : JumpState
{
    protected override void CheckRangeAttack(Animator animator)
    {
        if (UniData._inputs.RangeAttackInput())
        {
            animator.Play(AnimName.JumpSkill);
        }
    }
}
