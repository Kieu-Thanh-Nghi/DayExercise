using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMoveState : DState
{
    InputControl inputs;
    SpriteRenderer spriteRenderer;
    int moveAnimPriority;

    protected override StatesName thisStateName => StatesName.Move;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(_data.currentState != thisStateName)
        {
            _data.currentState = thisStateName;
            inputs = _data._inputs;
            spriteRenderer = _data._spriteRenderer;
            _data._charController.enabled = true;
            _data._moveControl.enabled = true;
        }
    }
    //public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash)
    //{
    //    inputs = _data._inputs;
    //    spriteRenderer = _data._spriteRenderer;
    //    _data._charController.enabled = true;
    //    _data._moveControl.enabled = true;
    //}
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        //if (_data.currentState != thisStateName)
        //{
        //    _data.currentState = thisStateName;
        //}
        SetUpAnim(animator, inputs.MoveInput(), inputs.UpDownInput());
    }

    void SetUpAnim(Animator animator, float dir, float dirUpDown)
    {
        moveAnimPriority = 0;
        int animDirect = 1;
        if (spriteRenderer.flipX) animDirect = -1;
        if (dirUpDown > 0) moveAnimPriority = 4;
        if (dir * animDirect > 0) moveAnimPriority = 2;
        else if (dir * animDirect < 0) moveAnimPriority = 3;
        if (dirUpDown < 0) moveAnimPriority = 1;
        animator.SetInteger(AnimName.Move, moveAnimPriority);
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (_data.currentState == thisStateName) return;
        animator.SetInteger(AnimName.Move, -1);
        _data._charController.enabled = false;
        _data._moveControl.enabled = false;
        Debug.Log("2");
    }

    //public override void OnStateMachineExit(Animator animator, int stateMachinePathHash)
    //{
    //    if (_stateName == StatesName.Move) return;
    //    animator.SetInteger(AnimName.Move, -1);
    //    _data._charController.enabled = false;
    //    _data._moveControl.enabled = false;
    //}
}
