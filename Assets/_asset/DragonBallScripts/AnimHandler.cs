using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimHandler : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;

    internal void PlayHurt(int hurtCount)
    {
        if(hurtCount == -1)
        {
            animator.SetInteger(AnimName.Hurt, -1);
            return;
        }
        animator.SetInteger(AnimName.Hurt, hurtCount);
    }

    [SerializeField] Animator animator;
    TeleAtkSM teleAtkSM;

    private void Awake()
    {
        teleAtkSM = animator.GetBehaviour<TeleAtkSM>();
    }

    internal void PlayAtk(int atkIndex)
    {
        animator.SetInteger(AnimName.AtkCombo, atkIndex + 1);
        if(atkIndex < 0)
        {
            animator.SetInteger(AnimName.AtkCombo, -1);
        }
    }

    internal void PlayAtkSuper(bool isStop = false)
    {
        if (isStop)
        {
            animator.SetInteger(AnimName.AtkSuper, -1);
            return;
        }
        if(animator.GetInteger(AnimName.AtkSuper) == 1)
        {
            animator.SetInteger(AnimName.AtkSuper, 2);
            return;
        }
        animator.SetInteger(AnimName.AtkSuper, 1);
    }

    internal void PlayTeleport()
    {
        animator.SetTrigger(AnimName.TeleportStart);
    }

    internal void PlayKiBeam(bool isShoot = false, bool isEnd = false)
    {
        if (isEnd)
        {
            animator.SetInteger(AnimName.KiBeam, -1);
            return;
        }       
        if (isShoot)
        {
            animator.SetInteger(AnimName.KiBeam, 1);
        }
        else
        {
            animator.SetInteger(AnimName.KiBeam, 0);
        }

    }

    internal bool IsAnAtkEnd()
    {
        return animator.GetInteger(AnimName.AtkCombo) == 0;
    }

    internal void PlayTeleAtk(bool atkOver = false)
    {
        if (atkOver)
        {
            animator.SetInteger(AnimName.TeleAtk, -1);
        }
        else
        {
            animator.SetInteger(AnimName.TeleAtk, UnityEngine.Random.Range(1,5));
        }
    }

    internal void PlaySSkill()
    {
        animator.SetTrigger(AnimName.SSkill);
    }


    internal bool PlayTransform(bool CheckAnimEnd = false)
    {
        if (CheckAnimEnd)
        {
            return animator.GetInteger(AnimName.CharTransform) == -1;
        }
        animator.SetInteger(AnimName.CharTransform, 0);
        return false;
    }

    AnimatorStateInfo stateInfo;

    internal bool PlayKiBlast(bool CheckKiBlastAnimEnd = false)
    {
        if (CheckKiBlastAnimEnd && animator.GetInteger(AnimName.KiBlast) > 0)
        {
            if (IsAnAnimEnd())
            {
                animator.SetInteger(AnimName.KiBlast, -1);
                return true;
            }
            else
            {
                return false;
            }
            
        }
        if(animator.GetInteger(AnimName.KiBlast) == -1)
        {
            animator.SetInteger(AnimName.KiBlast, 0);
        }
        return false;
    }

    public bool IsAnAnimEnd()
    {
        if (animator.IsInTransition(0)) return false;
        stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        return stateInfo.normalizedTime >= 1f;
    }

    internal void PlayDash(bool isStop = false)
    {
        if (isStop)
        { 
            animator.SetBool(AnimName.Dash, false);
        }
        else
        {
            animator.SetBool(AnimName.Dash, true);
        }
    }    

    int chargeValue;
    internal void PlayCharge(bool input)
    {
        chargeValue = animator.GetInteger(AnimName.KiCharge);
        if(chargeValue < 2)
        {
            animator.SetInteger(AnimName.KiCharge, ++chargeValue);
        }
        if (!input)
        {
            animator.SetInteger(AnimName.KiCharge, 0);
        }
    }

    internal void PlayBlock(bool blockInput)
    {
        animator.SetBool(AnimName.Block, blockInput);
    }

    internal void PlayMove(float dirLeftRight, float dirUpDown)
    {
        int moveAnimPriority;
        moveAnimPriority = 0;
        int animDirect = 1;
        if (spriteRenderer.flipX) animDirect = -1;
        if (dirUpDown > 0) moveAnimPriority = 4;
        if (dirLeftRight * animDirect > 0) moveAnimPriority = 2;
        else if (dirLeftRight * animDirect < 0) moveAnimPriority = 3;
        if (dirUpDown < 0) moveAnimPriority = 1;
        animator.SetInteger(AnimName.Move, moveAnimPriority);        
    }
}
