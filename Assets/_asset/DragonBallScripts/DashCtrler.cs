using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashCtrler : AloneState
{
    [SerializeField] DForceForward forceForward;
    [SerializeField] float dashForce = 10;
    [SerializeField] float timeToStopDash = 0.5f;
    protected override void OnEnable()
    {
        base.OnEnable();
        animHandle.PlayDash();
        forceForward.AddForce(dashForce, timeToStopDash);
    }
    private void Update()
    {
        if (forceForward.IsForceStop())
        {
            animHandle.PlayDash(isStop: true);
            this.enabled = false;
        }
    }
}
