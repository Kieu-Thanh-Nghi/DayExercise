using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeCtrler : AloneState
{
    bool _chanrgeInput;
    bool clickAble = true;
    [SerializeField] float teleTime;
    private void Update()
    {
        if (clickAble)
        {
            if (inputs.DashInput())
            {
                animHandle.PlayTeleport();
                clickAble = false;
                Invoke(nameof(setClickAble), teleTime);
                return;
            }
            if (inputs.KiBlastInput())
            {
                animHandle.PlayKiBeam();
                GetComponent<KiBeamCtrler>().enabled = true;
                clickAble = false;
                return;
            }
            if (inputs.attackInput())
            {
                animHandle.PlayAtkSuper();
                GetComponent<AttackSuperCtrler>().enabled = true;
                clickAble = false;
                return;
            }
            _chanrgeInput = inputs.KiChargeInput();
            animHandle.PlayCharge(_chanrgeInput);
            if (!_chanrgeInput) this.enabled = false;
        }

    }
    
    public void setClickAble()
    {
        clickAble = true;
    }
    protected override void OnDisable()
    {
        clickAble = true;
        base.OnDisable();
        animHandle.PlayCharge(false);
    }
}
