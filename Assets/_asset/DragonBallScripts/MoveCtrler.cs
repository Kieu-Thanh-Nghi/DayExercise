using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCtrler : StatesController
{
    [SerializeField] MoveLogic move;
    float DirLeftRight;
    float DirUpDown;
    // Update is called once per frame
    void Update()
    {
        DirLeftRight = inputs.MoveInput();
        DirUpDown = inputs.UpDownInput();
        animHandle.PlayMove(DirLeftRight, DirUpDown);
    }
    private void FixedUpdate()
    {
        move.going(DirLeftRight, DirUpDown);
    }
}
