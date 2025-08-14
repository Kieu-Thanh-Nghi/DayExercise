using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    InputControl inputs;
    Animator animator;
    UniformStatesData sData;
    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        //DState[] states = animator.GetBehaviours<DState>();
        //Debug.Log(states.Length);
        sData = GetComponentInChildren<UniformStatesData>();
        //foreach (var state in states)
        //{
        //    state.SetUp(sData);
        //}
        inputs = GetComponentInChildren<InputControl>();
    }
    // Update is called once per frame
    void Update()
    {
        if (inputs.KiChargeInput())
        {
            animator.SetInteger(AnimName.KiCharge, 1);
            return;
        }
        if (inputs.CharTransformInput())
        {
            animator.SetTrigger(AnimName.CharTransform);
            return;
        }
        if (inputs.DashInput())
        {
            animator.SetBool(AnimName.Dash, true);
            return;
        }
        if (inputs.KiBlastInput())
        {
            animator.SetInteger(AnimName.KiBlast, animator.GetBehaviour<DKiBlastState>().index);
            return;
        }
        if (inputs.BlockInput())
        {
            animator.SetBool(AnimName.Block, true);
            return;
        }
        if (inputs.SSKillInput())
        {
            animator.SetTrigger(AnimName.SSkill);
            return;
        }
        if (inputs.attackInput())
        {
            animator.SetInteger(AnimName.AtkCombo,0);
            return;
        }
    }
}
