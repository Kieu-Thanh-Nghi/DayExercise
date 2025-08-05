using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkFuncWarrior : AttackFuncs
{
    public override void CheckAllSpecialActs(Animator animator, InputControl _inputs)
    {
        CheckFlyKick(animator, _inputs);
        CheckSlide(animator, _inputs);
    }
}
