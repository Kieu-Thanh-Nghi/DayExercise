using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkCtrler : AloneState
{
    [SerializeField] int maxAtkCombo = 3;
    [SerializeField] atkCollide atkColl;
    int clickedAtkInput = 0;
    int firstMustHitAtk = 1;
    WaitUntil wait;
    [SerializeField] bool isHit;

    void checkIsHit()
    {
        isHit = true;
    }
    private void Start()
    {
        atkColl.HitTrigger += checkIsHit;
    }
    protected override void OnEnable()
    {
        wait = new WaitUntil(() => animHandle.IsAnAtkEnd());
        base.OnEnable();
        clickedAtkInput = 0;
        isHit = false;
        StartCoroutine(AtkChain());
    }

    private void Update()
    {
        if(clickedAtkInput < maxAtkCombo && inputs.attackInput())
        {
            clickedAtkInput++;
        }
    }

    IEnumerator AtkChain()
    {
        
        for (int i = 0; i <= clickedAtkInput; i++)
        {
            animHandle.PlayAtk(i);
            yield return wait;
            if(i >= firstMustHitAtk && !isHit)
            {
                break;
            }
            isHit = false;
            if(i == maxAtkCombo)
            {
                GetComponent<TeleAtkCtrler>().enabled = true;
                this.enabled = false;
                yield break;
            }
        }
        animHandle.PlayAtk(-1);
        this.enabled = false;
    }

    protected override void OnDisable()
    {
        if (!GetComponent<TeleAtkCtrler>().enabled)
        {
            base.OnDisable();
        }
        StopAllCoroutines();
    }
}
