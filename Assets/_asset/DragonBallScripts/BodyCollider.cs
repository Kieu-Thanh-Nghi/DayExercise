using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyCollider : MonoBehaviour
{
    [SerializeField] CharHurt charHurt;
    [SerializeField] Animator animator;
    [SerializeField] float offHurtTime;
    public bool isImmunity = false;
    string[] HurtChain = { AnimName.HitUp, AnimName.HitBack, AnimName.HitUp, AnimName.HitHard };
    int hurtChainCount = 0;

    public void GetHurt()
    {
        if (isImmunity) {
            if(charHurt != null) charHurt.enabled = false;
            return;
        }
        if (!charHurt.enabled) { 
            charHurt.enabled = true;
            hurtChainCount = 0;
        } 
        animator.Play(HurtChain[hurtChainCount]);
        if(hurtChainCount == HurtChain.Length - 1)
        {
            charHurt.OffHurt(offHurtTime);
            return;
        }
        else
        {
            charHurt.OffHurt(offHurtTime);
        }
        hurtChainCount++;
    }
}
