using System;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] InputControl inputs;
    [SerializeField] PlayerPhysic physic;
    Move move;
    TurnSprite turn;
    Jump jump;
    private void Start()
    {
        move = GetComponent<Move>();
        turn = GetComponent<TurnSprite>();
        jump = GetComponent<Jump>();
    }
    private void FixedUpdate()
    {
        if (!inputs.DownInput())
        {
            move.Going(inputs.MoveInput());
        }
    }

    // Update is called once per frame
    void Update()
    {
        float dir = inputs.MoveInput();
        animator.SetFloat(AnimName.Walk, Mathf.Abs(dir));
        turn.Turn(dir);

        if (physic.isGround)
        {
            if (inputs.DownInput())
            {
                animator.SetFloat(AnimName.Walk, 0);
            }
            animator.SetBool(AnimName.Crouch, inputs.DownInput());

            if (inputs.JumpInput() && !inputs.DownInput())
            {
                animator.Play(AnimName.Idle);
                animator.SetBool(AnimName.Jump, true);
                jump.JumpUp();
            }
            else
            {
                animator.SetBool(AnimName.Jump, false);
            }
        }
        else
        {
            inputs.JumpInput();
            animator.SetBool(AnimName.Crouch, false);
        }

        if(inputs.MeleAttackInput())
            animator.SetTrigger(AnimName.AnimParameter.MeleAtkTrigger);        
        if(inputs.RangeAttackInput())
            animator.SetTrigger(AnimName.AnimParameter.RangeAtkTrigger);
        if(inputs.StrikeInput())
            animator.SetTrigger(AnimName.AnimParameter.StrikeTrigger);
        if(inputs.DashInput())
            animator.SetTrigger(AnimName.AnimParameter.DashTrigger);
    }

    private void LateUpdate()
    {
        animator.ResetTrigger(AnimName.AnimParameter.MeleAtkTrigger);
        animator.ResetTrigger(AnimName.AnimParameter.DashTrigger);
        animator.ResetTrigger(AnimName.AnimParameter.StrikeTrigger);
    }
}
