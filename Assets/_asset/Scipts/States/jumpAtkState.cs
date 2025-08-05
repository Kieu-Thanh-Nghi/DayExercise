using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpAtkState : StateBehavior
{
    protected Move move;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
        move = animator.GetComponent<Move>();
    }

    public override void FixedUpdateState()
    {
        move.Going(UniData._inputs.MoveInput());
    }
}
