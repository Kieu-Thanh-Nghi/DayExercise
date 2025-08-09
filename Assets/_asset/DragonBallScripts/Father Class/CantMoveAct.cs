using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CantMoveAct : MonoBehaviour
{
    MoveControl moveControl;
    CharController charController;
    protected InputControl inputs;
    protected Animator animator;
    protected AnimatorStateInfo stateInfo;
    protected void Awake()
    {
        moveControl = GetComponent<MoveControl>();
        charController = GetComponent<CharController>();
        animator = GetComponent<Animator>();
        inputs = GetComponentInChildren<InputControl>();
    }

    protected virtual void OnEnable()
    {
        moveControl.enabled = false;
        charController.enabled = false;
    }

    protected virtual void OnDisable()
    {
        moveControl.enabled = true;
        charController.enabled = true;
    }

    protected bool CheckAnimEnd(string name)
    {
        stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        return stateInfo.IsName(name) && stateInfo.normalizedTime >= 1f;
    }

    protected IEnumerator Teleport()
    {
        animator.Play(AnimName.TeleportStart);
        yield return new WaitUntil(() => CheckAnimEnd(AnimName.TeleportEnd));
    }
}
