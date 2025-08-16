using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleAtkSM : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetInteger(AnimName.TeleAtk, 0);
    }
}
