using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DChargeState : DState
{
    protected override StatesName thisStateName => StatesName.Charge;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (animator.GetInteger(AnimName.KiCharge) != 1) return;
        animator.SetInteger(AnimName.KiCharge, 2);
        Debug.Log("1");
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (!_data._inputs.KiChargeInput()) animator.SetInteger(AnimName.KiCharge, 0);
        else
        {
            if (_data._inputs.DashInput())
            {
                _data.currentState = StatesName.Teleport;
                animator.SetTrigger(AnimName.TeleportStart);
            }

            IsNextCombo(animator);
        }
    }

    void IsNextCombo(Animator animator)
    {
        if (_data.currentState != StatesName.Charge)
        {
            animator.SetInteger(AnimName.KiCharge, 0);
        }
    }
}
