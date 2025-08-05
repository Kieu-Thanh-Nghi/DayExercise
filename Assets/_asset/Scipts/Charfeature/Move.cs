using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] float speed;
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
}
