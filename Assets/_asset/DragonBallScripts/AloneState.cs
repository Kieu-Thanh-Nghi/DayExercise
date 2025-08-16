using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AloneState : StatesController
{
    protected virtual void OnEnable()
    {
        GetComponent<StatesController>().enabled = false;
        GetComponent<MoveCtrler>().enabled = false;
    }    
    
    protected virtual void OnDisable()
    {
        GetComponent<StatesController>().enabled = true;
        GetComponent<MoveCtrler>().enabled = true;
    }
}
