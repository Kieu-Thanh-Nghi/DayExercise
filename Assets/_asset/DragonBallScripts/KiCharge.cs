using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiCharge : CantMoveAct
{
    protected override void OnEnable()
    {
        base.OnEnable();
        animator.Play(AnimName.KiCharge);
    }
    // Update is called once per frame
    void Update()
    {
        if (!inputs.KiChargeInput())
        {
            this.enabled = false;
        }
    }
}
