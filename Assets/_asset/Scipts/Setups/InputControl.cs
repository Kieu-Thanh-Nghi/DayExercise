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

    DelayTemp DelayisJump = new();
    public bool JumpInput()
    {
        if (Input.GetKeyDown(keys.Jump))
        {
            return true;
        }
        else
        {
            return DelayisJump.value;
        }
    }
    WaitForSeconds wait = new WaitForSeconds(0.25f);
    public void JumpInputDelay()
    {
        if (Input.GetKeyDown(keys.Jump))
        {
            StopCoroutine("DelayInput");
            DelayisJump.value = false;
            StartCoroutine(DelayInput(DelayisJump, wait));
        }
    }

    internal bool BlockInput()
    {
        return Input.GetKey(keys.Block);
    }

    IEnumerator DelayInput(DelayTemp _a, WaitForSeconds wait)
    {
        _a.value = true;
        yield return wait;
        _a.value = false;
    }

    internal bool critAtkInput()
    {
        return Input.GetKeyDown(keys.critAtk);
    }

    internal bool MeleAtkInput()
    {
        return Input.GetKeyDown(keys.MeleAtk);
    }

    internal bool SlideInput()
    {
        return Input.GetKeyDown(keys.Slide);
    }

    internal bool RangeAttackInput()
    {
        return Input.GetKeyDown(keys.RangeAtk);
    }

    internal bool StrikeInput()
    {
        return Input.GetKeyDown(keys.Strike);
    }

    internal bool FlyKickInput()
    {
        return Input.GetKeyDown(keys.Dash);
    } 
}

class DelayTemp{
    public bool value;
}
