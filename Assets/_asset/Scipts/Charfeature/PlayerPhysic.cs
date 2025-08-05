using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPhysic : MonoBehaviour
{
    public bool isGround;
    public bool isFalling;
    public bool isUp;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {        
        if (rb.velocity.y < -0.5) isFalling = true;
        else isFalling = false;
        if (rb.velocity.y > 0.5) isUp = true;
        else isUp = false;
    }
}
