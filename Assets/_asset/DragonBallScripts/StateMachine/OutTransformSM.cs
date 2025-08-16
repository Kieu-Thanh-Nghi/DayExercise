using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutTransformSM : StateMachineBehaviour
{
    public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
    {
        animator.SetInteger(AnimName.CharTransform, 1);
    }
    public override void OnStateMachineExit(Animator animator, int stateMachinePathHash)
    {
        animator.SetInteger(AnimName.CharTransform, -1);
    }
}
