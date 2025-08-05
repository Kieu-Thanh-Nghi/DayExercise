using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnableStateBehavior : StateBehavior
{
    public override void FixedUpdateState()
    {
        
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        CheckTurn();
        CheckAllAtkActions(animator);
    }

    protected virtual void CheckAllAtkActions(Animator animator)
    {
        CheckRangeAttack(animator);
        CheckMeleAttack(animator);
        UniData._specialActions?.CheckAllSpecialActs(animator, UniData._inputs);
    }
    protected virtual void CheckRangeAttack(Animator animator)
    {
        if (UniData._inputs.RangeAttackInput())
        {
            animator.Play(AnimName.RangeAttack);
        }
    }    
    
    protected virtual void CheckMeleAttack(Animator animator)
    {
        if (UniData._inputs.MeleAtkInput())
        {
            animator.Play(AnimName.MeleAttack);
        }
    }
    
    protected virtual void CheckTurn()
    {
        UniData._playerCtrl.GetComponent<TurnSprite>().Turn(Input.GetAxis("Horizontal"));
    }
}
