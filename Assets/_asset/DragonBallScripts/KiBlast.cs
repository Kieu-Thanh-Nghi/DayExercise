using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiBlast : CantMoveAct
{
    [SerializeField] int index = 0;
    protected override void OnEnable()
    {
        base.OnEnable();
        if(index == 0)
        {
            animator.Play(AnimName.KiBlast0);
            index = 1;
        }
        else
        {
            animator.Play(AnimName.KiBlast1);
            index = 0;
        }
    }

    private void Update()
    {
        if(CheckAnimEnd(AnimName.KiBlast0) || CheckAnimEnd(AnimName.KiBlast1)){
            this.enabled = false;
        }
    }
}
