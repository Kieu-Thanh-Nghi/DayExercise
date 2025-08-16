using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSM : StateMachineBehaviour
{
    bool isCheck = false;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        isCheck = true;
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        if(stateInfo.normalizedTime >= 1f && isCheck)
        {
            animator.SetInteger(AnimName.AtkCombo, 0);
            isCheck = false;
        }
    }
}
