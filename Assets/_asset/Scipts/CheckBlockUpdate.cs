using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBlockUpdate : MonoBehaviour
{
    Animator animator;
    InputControl inputs;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        inputs = GetComponent<InputControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (inputs.BlockInput())
        {
            if (!animator.GetBool(AnimName.AnimParameter.IsBlock))
            {
                animator.SetBool(AnimName.AnimParameter.IsBlock, true);
                animator.Play(AnimName.Block);
            }
        }
        else
        {
            animator.SetBool(AnimName.AnimParameter.IsBlock, false);
        }
    }
}
