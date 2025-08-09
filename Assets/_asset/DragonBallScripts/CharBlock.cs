using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharBlock : CantMoveAct
{
    protected override void OnEnable()
    {
        base.OnEnable();
        animator.Play(AnimName.Block);
    }
    // Update is called once per frame
    void Update()
    {
        if (!inputs.BlockInput())
        {
            this.enabled = false;
        }
    }
}
