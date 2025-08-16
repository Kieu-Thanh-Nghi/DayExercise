using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DForceForward : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb; 
    bool isStop;

    public void AddForce(float ForceAmount, float timeToStop)
    {
        StopAllCoroutines();
        isStop = false;
        rb.velocity = Vector2.zero;
        rb.velocity = transform.right * ForceAmount;
        StartCoroutine(CheckTimeToStop(timeToStop));
    }

    public void StopNow()
    {
        StopAllCoroutines();
        isStop = false;
        rb.velocity = Vector2.zero;
    }
    public bool IsForceStop()
    {
        if(rb.velocity == Vector2.zero)
        {
            StopAllCoroutines();
            isStop = true;
        }
        return isStop;
    }

    IEnumerator CheckTimeToStop(float timeToStop)
    {
        yield return new WaitForSeconds(timeToStop);
        rb.velocity = Vector2.zero;
        isStop = true;
    }
}
