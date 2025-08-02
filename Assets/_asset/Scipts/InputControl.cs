using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControl : MonoBehaviour
{
    [SerializeField] KeyCodeCtrl keys;
    public bool DownInput()
    {
        return Input.GetKey(keys.Down);
    }
    public float MoveInput()
    {
        return Input.GetAxis("Horizontal");
    }

    bool isJump;
    public bool JumpInput()
    {
        if (Input.GetKeyDown(keys.Jump))
        {
            isJump = true;
            StopCoroutine(waitAJump());
            StartCoroutine(waitAJump());
            return isJump;
        }
        return isJump;
    }

    internal bool MeleAttackInput()
    {
        return Input.GetKeyDown(keys.MeleAtk);
    }    
    
    internal bool RangeAttackInput()
    {
        return Input.GetKeyDown(keys.RangeAtk);
    }

    internal bool StrikeInput()
    {
        return Input.GetKeyDown(keys.Strike);
    }

    internal bool DashInput()
    {
        return Input.GetKeyDown(keys.Dash);
    }

    IEnumerator waitAJump()
    {
        var wait = new WaitForSeconds(0.25f);
        yield return wait;
        isJump = false;
    }   
    
    IEnumerator w(A _a)
    {
        var wait = new WaitForSeconds(0.25f);
        yield return wait;
        _a.value = !_a.value;
    }

    A isJumpDelay = new();
    public bool J()
    {
        if (Input.GetKeyDown(keys.Jump))
        {
            isJumpDelay.value = true;
            StopCoroutine(w(isJumpDelay));
            StartCoroutine(w(isJumpDelay));
            return isJumpDelay.value;
        }
        return isJumpDelay.value;
    }
}

struct A{
    public bool value;
}
