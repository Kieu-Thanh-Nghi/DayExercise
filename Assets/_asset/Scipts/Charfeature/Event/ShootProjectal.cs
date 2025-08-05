using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectal : MonoBehaviour
{
    [SerializeField] GameObject FireBallPrefab;
    [SerializeField] GameObject IblastPrefab;
    [SerializeField] GameObject Particle;
    [SerializeField] Transform ShootPosition;

    public void CreateFireBall()
    {
        Instantiate(FireBallPrefab, ShootPosition.position, ShootPosition.rotation);
    }

    public void CreateIBlast()
    {
        Instantiate(IblastPrefab, ShootPosition.position, ShootPosition.rotation);
    }    
    
    public void CreateParticle()
    {
        Instantiate(Particle, ShootPosition.position, ShootPosition.rotation);
    }
}
