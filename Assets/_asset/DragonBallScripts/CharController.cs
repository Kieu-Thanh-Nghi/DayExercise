using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    KiCharge _charge;
    InputControl inputs;
    private void Start()
    {
        _charge = GetComponent<KiCharge>();
        inputs = GetComponentInChildren<InputControl>();
        Debug.Log(_charge);
    }
    // Update is called once per frame
    void Update()
    {
        if (inputs.KiChargeInput())
        {
            _charge.enabled = true;
            return;
        }
        if (inputs.CharTransformInput())
        {
            GetComponent<CharTransform>().enabled = true;
            return;
        }
        if (inputs.DashInput())
        {
            GetComponent<CharDash>().enabled = true;
            return;
        }
        if (inputs.KiBlastInput())
        {
            GetComponent<KiBlast>().enabled = true;
            return;
        }       
        if (inputs.BlockInput())
        {
            GetComponent<CharBlock>().enabled = true;
            return;
        }
        if (inputs.SSKillInput())
        {
            GetComponent<CharSpecialSkill>().enabled = true;
            return;
        }
        if (inputs.attackInput())
        {
            GetComponent<CharAttack>().enabled = true;
            return;
        }
    }
}
