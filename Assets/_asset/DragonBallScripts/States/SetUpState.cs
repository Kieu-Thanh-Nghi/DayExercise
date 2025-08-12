using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetUpState : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        DState[] states = animator.GetBehaviours<DState>();
        Debug.Log(states.Length);
        UniformStatesData sData = animator.GetComponentInChildren<UniformStatesData>();
        foreach (var state in states)
        {
            state.SetUp(sData);
        }
        sData.currentState = StatesName.NoState;
    }
}
