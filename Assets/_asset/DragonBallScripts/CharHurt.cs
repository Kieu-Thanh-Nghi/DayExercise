using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharHurt : CantMoveAct
{
    public void OffHurt(float offHurtTime = 0.3f)
    {
        CancelInvoke();
        Invoke(nameof(DisableThis), offHurtTime);
    }

    void DisableThis()
    {
        this.enabled = false;
    }
}
