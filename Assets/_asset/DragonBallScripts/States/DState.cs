using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DState : StateMachineBehaviour
{
    protected UniformStatesData _data;

    protected AnimatorStateInfo stateInfo;

    protected bool isInState = false;
    protected abstract StatesName thisStateName { get; }

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (thisStateName != _data.currentState) DoWhenEnter(animator);
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (_data.currentState == thisStateName)
        {
            DoWhenInState(animator);
        }
    }

    protected abstract void DoWhenInState(Animator animator);

    protected virtual void DoWhenEnter(Animator animator)
    {
        _data.currentState = thisStateName;
    }
    protected bool CheckAnimEnd(Animator animator)
    {
        if (animator.IsInTransition(0)) return false;
        stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        return stateInfo.normalizedTime >= 1f;
    }
    public virtual void SetUp(UniformStatesData data)
    {
        _data = data;
    }
}
