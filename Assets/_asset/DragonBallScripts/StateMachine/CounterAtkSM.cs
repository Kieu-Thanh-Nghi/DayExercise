using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterAtkSM : StateMachineBehaviour
{
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.GetComponent<CounterCtrler>().StopThisState();
    }
}
