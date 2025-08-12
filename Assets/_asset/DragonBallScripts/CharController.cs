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
        if (inputs.KiChargeInput() && sData.currentState != StatesName.Charge)
        {
            sData.currentState = StatesName.Charge;
            animator.SetInteger(AnimName.KiCharge, 1);
            return;
        }
        if (inputs.CharTransformInput() && sData.currentState != StatesName.Transform)
        {
            sData.currentState = StatesName.Transform;
            animator.SetTrigger(AnimName.CharTransform);
            return;
        }
        if (inputs.DashInput() && sData.currentState != StatesName.Dash)
        {
            sData.currentState = StatesName.Dash;
            animator.SetBool(AnimName.Dash, true);
            return;
        }
        if (inputs.KiBlastInput() && sData.currentState != StatesName.KiBlast)
        {
            sData.currentState = StatesName.KiBlast;
            animator.SetInteger(AnimName.KiBlast, animator.GetBehaviour<DKiBlastState>().index);
            return;
        }
        if (inputs.BlockInput() && sData.currentState != StatesName.Block)
        {
            sData.currentState = StatesName.Block;
            animator.SetBool(AnimName.Block, true);
            return;
        }
        if (inputs.SSKillInput() && sData.currentState != StatesName.SpecialSkill)
        {
            sData.currentState = StatesName.SpecialSkill;
            animator.SetTrigger(AnimName.SSkill);
            return;
        }
        if (inputs.attackInput())
        {
            sData.currentState = StatesName.Attack;
            animator.SetInteger(AnimName.AtkCombo,0);
            return;
        }
    }
}
