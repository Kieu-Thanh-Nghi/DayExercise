using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    [SerializeField] Transform direct;
    [SerializeField] Rigidbody2D rb;
    public void ForceForward(float ForceAmount)
    {
        rb.velocity = Vector2.zero;
        rb.AddForce(direct.right * ForceAmount);
    }
}
