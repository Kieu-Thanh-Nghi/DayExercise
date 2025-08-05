using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddEffAnim : MonoBehaviour
{
    [SerializeField] GameObject EffPrefab;
    [SerializeField] Transform DashPosition;
    public void CreateEffDash(float effDestroyTime = 0.5f)
    {
        var AEff = Instantiate(EffPrefab,DashPosition.position,DashPosition.rotation);
        Destroy(AEff, effDestroyTime);
    }
}
