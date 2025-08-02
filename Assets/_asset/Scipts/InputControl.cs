using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControl : MonoBehaviour
{
    public bool DownInput()
    {
        return Input.GetKey(KeyCode.S);
    }
    public float MoveInput()
    {
        return Input.GetAxis("Horizontal");
    }

    bool isJump;
    public bool JumpInput()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJump = true;
            StopCoroutine(waitAJump());
            StartCoroutine(waitAJump());
            return isJump;
        }
        return isJump;
    }

    internal bool AttackInput()
    {
        return Input.GetKeyDown(KeyCode.J);
    }

    internal bool StrikeInput()
    {
        return Input.GetKeyDown(KeyCode.K);
    }

    internal bool DashInput()
    {
        return Input.GetKeyDown(KeyCode.L);
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
        if (Input.GetKeyDown(KeyCode.Space))
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
