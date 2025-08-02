using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Transform direct;
    public bool isMoving;

    public void Going(float direction)
    {
        transform.Translate(direction * Time.fixedDeltaTime * speed, 0 , 0);
        if(Mathf.Abs(direction) < 0.1)
        {
            isMoving = false;
        }
        else
        {
            isMoving = true;
        }
    }

    public void ForceForward(float forceAmout)
    {
        rb.velocity = Vector2.zero;
        Vector2 dir = direct.right;
        rb.AddForce(dir * forceAmout);
    }
}
