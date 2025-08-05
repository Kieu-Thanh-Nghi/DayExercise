using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float do_lon;
    public void JumpUp()
    {
        rb.velocity = Vector2.up * do_lon;
    }
}
