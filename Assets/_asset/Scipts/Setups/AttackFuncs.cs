using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackFuncs : MonoBehaviour
{
    public virtual void CheckAllSpecialActs(Animator animator, InputControl _inputs)
    {
        CheckStrike(animator, _inputs);
        CheckFlyKick(animator, _inputs);
    }
    public virtual void CheckStrike(Animator animator, InputControl _inputs)
    {
        if (_inputs.StrikeInput())
        {
            animator.Play(AnimName.Strike);
        }
    }

    public virtual void CheckFlyKick(Animator animator, InputControl _inputs)
    {
        if (_inputs.FlyKickInput())
        {
            animator.Play(AnimName.Dash);
        }
    }    
    
    public virtual void CheckBlock(Animator animator, InputControl _inputs)
    {
        if (_inputs.BlockInput() && !animator.GetBool(AnimName.AnimParameter.IsBlocking))
        {
            animator.Play(AnimName.Block);
            animator.SetBool(AnimName.AnimParameter.IsBlocking, true);
        }
    }    
    
    public virtual void CheckCritAttack(Animator animator, InputControl _inputs)
    {
        if (_inputs.critAtkInput())
        {
            animator.Play(AnimName.CritAttack);
        }
    }    
    
    public virtual void CheckSlide(Animator animator, InputControl _inputs)
    {
        if (_inputs.SlideInput())
        {
            animator.Play(AnimName.Slide);
        }
    }

}
