using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SSKillCtrler : AloneState
{
    protected override void OnEnable()
    {
        base.OnEnable();
        animHandle.PlaySSkill();
    }

    public void GetOutThisState()
    {
        this.enabled = false;
    }
}
