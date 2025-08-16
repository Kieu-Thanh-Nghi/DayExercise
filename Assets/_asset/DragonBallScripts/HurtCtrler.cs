using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtCtrler : AloneState
{
    [SerializeField] float hitHardEndTime = 1;
    [SerializeField] float hitEndTime = 0.5f;
    int hurtTimes = 4;
    int hurtCount = 1;

    protected override void OnEnable()
    {
        base.OnEnable();
        hurtCount = 1;
    }
    public void DoWhenHurt()
    {
        if (hurtCount > hurtTimes) return;
        animHandle.PlayHurt(hurtCount);
        CancelInvoke(nameof(EndHurt));
        if(hurtCount == hurtTimes)
        {
            Invoke(nameof(EndHurt), hitHardEndTime);
        }
        else
        {
            Invoke(nameof(EndHurt), hitEndTime);
        }
        hurtCount++;
    }

    public void EndHurt()
    {
        animHandle.PlayHurt(-1);
        this.enabled = false;
    }
}
