using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleAttack : CantMoveAct
{
    [SerializeField] int teleAtkTimes = 4;
    int teleAtkCount = 4;
    string[] teleAtks = { AnimName.TeleAtkBack, AnimName.TeleAtkDown, AnimName.TeleAtkForward, AnimName.TeleAtkUp };
    bool clickAvailable = true;
    protected override void OnEnable()
    {
        base.OnEnable();
        teleAtkCount = teleAtkTimes;
        clickAvailable = true;
        StartCoroutine(setOffAtk(0.3f));
    }

    private void Update()
    {
        if (teleAtkCount > 0 && clickAvailable && inputs.teleAtkInput())
        {
            clickAvailable = false;
            StopAllCoroutines();
            StartCoroutine(TeleAtk(0.3f, 0.3f));
            teleAtkCount--;
        }
    }
    protected IEnumerator TeleAtk(float time, float timeToOff)
    {
        yield return StartCoroutine(Teleport());
        animator.Play(teleAtks[UnityEngine.Random.Range(0, 4)]);
        yield return StartCoroutine(setClickAvail(time));
        yield return StartCoroutine(setOffAtk(timeToOff));
    }

    IEnumerator setClickAvail(float time)
    {
        yield return new WaitForSeconds(time);
        clickAvailable = true;
    }    
    
    IEnumerator setOffAtk(float timeToOff)
    {
        yield return new WaitForSeconds(timeToOff);
        this.enabled = false;
    }
}
