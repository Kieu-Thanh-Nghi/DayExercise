using System;
using UnityEngine;

public class BeamCharge : MonoBehaviour
{
    public Action DoWhenDestroy;
    public void DestroyThis()
    {
        DoWhenDestroy?.Invoke();
        Destroy(this.gameObject);
    }
}
