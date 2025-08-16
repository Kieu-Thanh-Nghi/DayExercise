using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLogic : MonoBehaviour
{
    [SerializeField] float speed;

    internal void going(float dir1, float dir2)
    {
        transform.Translate(dir1 * speed, 0, 0);
        transform.Translate(0, dir2 * speed, 0);
    }
}
