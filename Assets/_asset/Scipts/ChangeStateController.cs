using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeStateController : MonoBehaviour
{
    [SerializeField] InputControl inputs;
    [SerializeField] PlayerPhysic physic;

    public bool toCrouchState()
    {
        if (inputs.DownInput() && physic.isGround)
        {
            return true;
        }
        return false;
    }

    internal bool toAttackState()
    {
        return inputs.AttackInput();
    }

    internal bool toStrikeState()
    {
        return inputs.StrikeInput();
    }

    public bool CrouchToIdle()
    {
        if(!inputs.DownInput()) return true;
        return false;
    }
    public bool toMoveState()
    {
        if (Mathf.Abs(inputs.MoveInput()) > 0.1) return true;
        return false;
    }
    public bool toIdleState()
    {
        if (Mathf.Abs(inputs.MoveInput()) < 0.1)
        {
            return true;
        }
        return false;
    }

    public bool JumpToIdle()
    {
        if (physic.isGround && !physic.isUp && !physic.isFalling)
        {
            return true;
        }
        return false;
    }
    public bool toJumpState()
    {
        if (inputs.JumpInput() || physic.isFalling)
        {
            return true;
        }
        return false;
    }

    internal bool CrouchtoIdle()
    {
        return !inputs.DownInput();
    }
}
