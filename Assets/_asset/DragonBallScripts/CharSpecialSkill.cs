using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSpecialSkill : CantMoveAct
{
    override protected void OnEnable()
    {
        base.OnEnable();
        animator.Play(AnimName.SSkillCharge);
    }

    private void Update()
    {
        if (CheckAnimEnd(AnimName.SSkill))
        {
            this.enabled = false;
        }
    }
}
