using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DTeleAtkState : DState
{
    int maxAtkAmount = 5;
    int atkCount = 2;
    bool isAtkAble;
    protected override StatesName thisStateName => StatesName.TeleAttak;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);
        isAtkAble = true;
        animator.SetInteger(AnimName.TeleAtk, 0);
    }
    protected override void DoWhenEnter(Animator animator)
    {
        base.DoWhenEnter(animator);
        atkCount = 2; 
    }

    protected override void DoWhenInState(Animator animator)
    {
        if(isAtkAble && CheckAnimEnd(animator))
        {
            animator.SetInteger(AnimName.TeleAtk, -1);
        }
        if (atkCount < maxAtkAmount)
        {
            
            if (isAtkAble && _data._inputs.teleAtkInput())
            {
                animator.SetInteger(AnimName.TeleAtk, Random.Range(1, maxAtkAmount));
                atkCount++;
                isAtkAble = false;
                return;
            }
            else if(stateInfo.normalizedTime >= 1)
            {
                //animator.SetInteger(AnimName.TeleAtk, -1);
            }
        }     
    }
}
