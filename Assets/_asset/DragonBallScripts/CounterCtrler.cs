using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterCtrler : AloneState
{
    [SerializeField] float force;
    [SerializeField] float timeToStop;
    [SerializeField] BodyCollide bodyCollide;
    [SerializeField] DForceForward forceForward;
    bool isNextAct = false;

    protected override void OnEnable()
    {
        base.OnEnable();
        animHandle.PlayCounter(1);
        forceForward.AddForce(force, timeToStop);
        bodyCollide.SetImunity(true);
        isNextAct = false;
    }

    private void Update()
    {
        if (isNextAct) return;
        if (forceForward.IsForceStop())
        {
            StopThisState();
        }
        else
        {
            if (bodyCollide.isCounter)
            {
                animHandle.PlayCounter(2);
                forceForward.StopNow();
                isNextAct = true;
            }
        }
    }

    public void StopThisState()
    {
        animHandle.PlayCounter(-1);
        this.enabled = false;
    }

    protected override void OnDisable()
    {
        bodyCollide.SetImunity(false);
        base.OnDisable();
        GetComponent<ChargeCtrler>().enabled = false;
    }
}
