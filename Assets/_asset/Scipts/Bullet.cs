using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float FlySpeed;
    [SerializeField] float LifeTime;

    private void Start()
    {
        Destroy(this.gameObject,LifeTime);
    }

    private void FixedUpdate()
    {
        transform.Translate(transform.right * FlySpeed * Time.fixedDeltaTime, Space.World);
    }

    public void SetUpFlySpeed(float newSpeed)
    {
        FlySpeed = newSpeed;
    }

    public void SetUpLifeTime(float newLifeTime)
    {
        LifeTime = newLifeTime;
    }
}
