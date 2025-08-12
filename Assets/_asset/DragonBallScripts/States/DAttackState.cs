using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DAttackState : DState
{
    int maxAttackChain = 4;
    int Attack = 0;
    protected override StatesName thisStateName => StatesName.Attack;

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (_data._inputs.attackInput() && Attack < maxAttackChain)
        {
            Attack++;
            Debug.Log(Attack);
            animator.SetInteger(AnimName.AtkCombo, Attack);
        }
    }
}
