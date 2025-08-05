using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustCrouchState : CrouchState
{
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        CrouchToIdle(animator);
        CheckTurn();
    }
}
