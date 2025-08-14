using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DAttackState : DCantMoveState
{
    int maxAttackChain = 3;
    int atkComboStart = 1;
    int AttackTimes = 0;
    int atkIndex = 1;
    bool isAnimEnd;
    public bool isHit;
    protected override StatesName thisStateName => StatesName.Attack;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
        isHit = false;
        isAnimEnd = true;
    }

    protected override void DoWhenEnter(Animator animator)
    {
        base.DoWhenEnter(animator);
        AttackTimes = 0;
        atkIndex = 1;
    }
    protected override void DoWhenInState(Animator animator)
    {
        if (isAnimEnd && atkIndex > maxAttackChain)
        {
            if (!CheckAnimEnd(animator))
            {
                if (_data._inputs.teleAtkInput())
                {
                    animator.SetInteger(AnimName.TeleAtk, 0);
                }  
            }
            else animator.SetInteger(AnimName.AtkCombo, -1);
            return;
        }
        if (_data._inputs.attackInput() && AttackTimes < maxAttackChain)
        {
            AttackTimes++;
        }

        if (isAnimEnd && CheckAnimEnd(animator))
        {
            if (atkIndex > AttackTimes)
            {
                animator.SetInteger(AnimName.AtkCombo, -1);
                return;
            }

            //if (atkIndex > atkComboStart && !isHit)
            //{
            //    animator.SetInteger(AnimName.AtkCombo, -1);
            //}
            animator.SetInteger(AnimName.AtkCombo, atkIndex);
            atkIndex++;
            isAnimEnd = false;
        }
    }
}
