using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSuperCtrler : AloneState
{
    [SerializeField] DForceForward forceForward;
    [SerializeField] atkCollide atkColl;
    [SerializeField] float AtkBeginForce = 10;
    [SerializeField] float timeToStopAtkBegin = 0.5f;
    [SerializeField] bool isTouch;
    bool isDoneBegin;
    protected override void OnEnable()
    {
        base.OnEnable();
        atkColl.isNotHurting = true;
        isTouch = false;
        isDoneBegin = false;
        forceForward.AddForce(AtkBeginForce, timeToStopAtkBegin);
    }

    private void Start()
    {
        atkColl.HitTrigger += SetIsTouch;
    }

    void SetIsTouch()
    {
        isTouch = true;
    }

    private void Update()
    {
        if (isTouch)
        {
            if (!isDoneBegin)
            {
                atkColl.isNotHurting = false;
                forceForward.StopNow();
                animHandle.PlayAtkSuper();
                isDoneBegin = true;
                return;
            }
        }
        else if (forceForward.IsForceStop())
        {
            this.enabled = false;
        }
    }

    public void StopAtkSuper()
    {
        this.enabled = false;
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        atkColl.isNotHurting = false;
        animHandle.PlayAtkSuper(isStop: true);
        isTouch = false;
        GetComponent<ChargeCtrler>().enabled = false;
    }
}
