using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharAttack : CantMoveAct
{
    [SerializeField] TeleAttack teleAttack;
    [SerializeField] int atkClickedTimes = 1;
    string[] atkCombos = { AnimName.AtkCombo0, AnimName.AtkCombo1, AnimName.AtkCombo2, AnimName.AtkCombo3 };
    int atkComboStart = 1;
    public bool isHit;
    protected override void OnEnable()
    {
        base.OnEnable();
        atkClickedTimes = 1;
        isHit = false;
        StartCoroutine(nameof(atkChain));
    }

    private void Update()
    {
        if (atkClickedTimes <= atkCombos.Length && inputs.attackInput())
        {
            atkClickedTimes++;
        }
    }

    IEnumerator atkChain()
    {
        for(int i = 0; i < atkCombos.Length; i++)
        {
            if(i < atkClickedTimes)
            {
                isHit = false;
                animator.Play(atkCombos[i]);
                yield return new WaitUntil(() => CheckAnimEnd(atkCombos[i]));
                if (i >= atkComboStart && !isHit) {
                    yield return new WaitForSeconds(0.3f);
                    base.OnDisable();
                    this.enabled = false;
                    yield break;
                }
            }
            else
            {
                yield return new WaitForSeconds(0.3f);
                base.OnDisable();
                this.enabled = false;
            }
        }
        teleAttack.enabled = true;
        this.enabled = false;
    }

    protected override void OnDisable()
    {
        StopAllCoroutines();
    }
}
