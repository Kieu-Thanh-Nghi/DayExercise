using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleAtkCtrler : AloneState
{
    [SerializeField] int maxAtkCombo = 3;
    int TeleAtkCount = 0;
    bool ClickAble;
    WaitForSeconds waitSecond, waitSecondBefore;
    WaitUntil waitAnimEnd;

    protected override void OnEnable()
    {
        waitSecond = new WaitForSeconds(1f);
        waitSecondBefore = new WaitForSeconds(1f);
        base.OnEnable();
        TeleAtkCount = 0;
        ClickAble = false;
        StartCoroutine(TeleAtkChain());
    }

    IEnumerator TeleAtkChain()
    {
        if(TeleAtkCount > 0)
        {
            yield return waitAnimEnd;
            yield return waitSecondBefore;
        }
        ClickAble = true;
        yield return waitSecond;
        if (ClickAble)
        {
            animHandle.PlayTeleAtk(atkOver: true);
            this.enabled = false;
        }
    }

    private void Update()
    {
        if(TeleAtkCount <= maxAtkCombo)
        {
            if (ClickAble && inputs.teleAtkInput())
            {
                animHandle.PlayTeleAtk();
                TeleAtkCount++;
                ClickAble = false;
                StopAllCoroutines();
                StartCoroutine(TeleAtkChain());
            }
        }
        if(TeleAtkCount > maxAtkCombo && ClickAble)
        {
            animHandle.PlayTeleAtk(atkOver: true);
            this.enabled = false;
        }
    }

    protected override void OnDisable()
    {
        base.OnDisable();
        StopAllCoroutines();
    }
}
