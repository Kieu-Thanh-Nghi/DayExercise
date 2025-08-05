using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateBehavior : StateMachineBehaviour
{
    [SerializeField] protected StateUniformData UniData;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        UniData._playerCtrl.state = this;
    }
    public void setUpState(StateUniformData uniData)
    {
        UniData = uniData;
    }
    public virtual void FixedUpdateState() { }
}
