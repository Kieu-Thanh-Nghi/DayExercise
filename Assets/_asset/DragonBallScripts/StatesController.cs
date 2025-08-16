using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatesController : MonoBehaviour
{
    protected InputControl inputs;
    protected AnimHandler animHandle;

    protected virtual void Awake()
    {
        inputs = GetComponentInChildren<InputControl>();
        animHandle = GetComponent<AnimHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inputs.KiChargeInput())
        {
            GetComponent<ChargeCtrler>().enabled = true;
            return;
        }
        if (inputs.DashInput())
        {
            GetComponent<DashCtrler>().enabled = true;
            return;
        }
        if (inputs.BlockInput())
        {
            GetComponent<BlockCtrler>().enabled = true;
            return;
        }
        if (inputs.KiBlastInput())
        {
            GetComponent<KiBastCtrler>().enabled = true;
            return;
        }
        if (inputs.CharTransformInput())
        {
            GetComponent<TransformCtrler>().enabled = true;
            return;
        }
        if (inputs.SSKillInput())
        {
            GetComponent<SSKillCtrler>().enabled = true;
            return;
        }    
        if (inputs.attackInput())
        {
            GetComponent<AtkCtrler>().enabled = true;
            return;
        }
    }
}
