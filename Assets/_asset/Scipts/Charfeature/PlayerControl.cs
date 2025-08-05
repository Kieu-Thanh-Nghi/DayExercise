using System;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public StateBehavior state;
    [SerializeField] Animator animator;
    [SerializeField] StateUniformData stateUniData;
    private void Start()
    {
        StateBehavior[] sbs = animator.GetBehaviours<StateBehavior>();
        Debug.Log(sbs.Length);
        foreach(var sb in sbs)
        {
            sb.setUpState(stateUniData);
        }
    }
    private void FixedUpdate()
    {
        state?.FixedUpdateState();
    }
}
