using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveControl : MonoBehaviour
{
    [SerializeField] float speed = 5;
    SpriteRenderer spriteRenderer;
    InputControl inputs;
    Animator animator;
    int moveAnimPriority;

    private void Start()
    {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        inputs = GetComponentInChildren<InputControl>();
        animator = GetComponentInChildren<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        SetUpAnim(inputs.MoveInput(), Input.GetAxis("Vertical"));
        WhichAnimPlay();
    }

    private void FixedUpdate()
    {
        MoveLeftRight(inputs.MoveInput());
        MoveUpDown(Input.GetAxis("Vertical"));
    }

    public void MoveLeftRight(float dir)
    {
        transform.Translate(dir * Time.fixedDeltaTime * speed, 0, 0);
    }    

    void SetUpAnim(float dir, float dirUpDown)
    {
        if (dirUpDown > 0.01f) moveAnimPriority = 4;
        if (dirUpDown < -0.01f) moveAnimPriority = 1;
        int animDirect = 1;
        if (spriteRenderer.flipX) animDirect = -1;
        if (dir * animDirect > 0.01f) moveAnimPriority = 2;
        else if (dir * animDirect < -0.1f) moveAnimPriority = 3;
        else moveAnimPriority = 0; 
        if (dirUpDown < -0.01f) moveAnimPriority = 1;
    }
    
    public void MoveUpDown(float dir)
    {
        transform.Translate(0, dir * Time.fixedDeltaTime * speed, 0);
    }

    void WhichAnimPlay()
    {
        switch(moveAnimPriority)
        {
            case 0:
                animator.Play(AnimName.Idle);
                break;
            case 1:
                animator.Play(AnimName.MoveDown);
                break;
            case 2:
                animator.Play(AnimName.MoveForward);
                break;
            case 3:
                animator.Play(AnimName.MoveBack);
                break;
            case 4:
                animator.Play(AnimName.MoveUp);
                break;
        }
    }
}
