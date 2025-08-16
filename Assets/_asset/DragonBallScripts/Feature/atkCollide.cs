using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atkCollide : MonoBehaviour
{
    public Action HitTrigger;
    public bool isNotHurting;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        BodyCollide EnemyBody = collision.GetComponent<BodyCollide>();
        if(EnemyBody != null)
        {
            if(!isNotHurting) EnemyBody.Hurt();
            HitTrigger?.Invoke();
        }
    }
}
