using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkFuncNinja : AttackFuncs
{
    public override void CheckAllSpecialActs(Animator animator, InputControl _inputs)
    {
        base.CheckAllSpecialActs(animator, _inputs);
        CheckBlock(animator, _inputs);
        CheckCritAttack(animator, _inputs);
    }
}
