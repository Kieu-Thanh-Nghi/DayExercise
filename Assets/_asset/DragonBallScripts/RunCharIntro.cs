using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunCharIntro : MonoBehaviour
{
    [SerializeField] CharController Controller;
    [SerializeField] Animator animator;
    AnimatorStateInfo stateInfo;
    WaitUntil waitUntil;
    // Start is called before the first frame update
    void Start()
    {
        stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        Debug.Log("ss");
        waitUntil = new WaitUntil(() => stateInfo.normalizedTime >= 1f);
        StartCoroutine(nameof(PlayAniIntro));
    }

    IEnumerator PlayAniIntro()
    {
        animator.Play(AnimName.PrePare);
        yield return new WaitUntil(() => CheckAnimEnd(AnimName.PrePare));
        animator.Play(AnimName.Intro);
        yield return new WaitUntil(() => CheckAnimEnd(AnimName.Intro));
        animator.Play(AnimName.Idle);
        Controller.enabled = true;
        yield break;
    }

    bool CheckAnimEnd(string name)
    {
        stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        return stateInfo.IsName(name) && stateInfo.normalizedTime >= 1f;
    }
}
