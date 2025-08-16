using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyCollide : MonoBehaviour
{
    [SerializeField] GameObject Character;
    [SerializeField] StatesController[] mb;
    [SerializeField] HurtCtrler hurtCtrler;

    [ContextMenu("Reset")]
    public void AllStates()
    {
        mb = Character.GetComponents<StatesController>();
    }

    public virtual void Hurt()
    {
        if(!hurtCtrler.enabled)
        {
            foreach (var m in mb)
            {
                if (m.enabled)
                {
                    m.enabled = false;
                }
            }
            hurtCtrler.enabled = true;
        }
        hurtCtrler.DoWhenHurt();
    }
}
