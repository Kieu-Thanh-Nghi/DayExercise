using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSprite : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Transform ShootAndDirectPoints;
    Quaternion fixedRotation;

    private void Start()
    {
        if (ShootAndDirectPoints == null) return;
        fixedRotation = ShootAndDirectPoints.rotation;
    }
    public void Turn(float direct)
    {
        if (direct < -0.1)
        {
            if (spriteRenderer.flipX) return;
            spriteRenderer.flipX = true;
            if (ShootAndDirectPoints == null) return;
            ShootAndDirectPoints.Rotate(new Vector3(0, 180, 0));
        }
        else if (direct > 0.1)
        {
            if (!spriteRenderer.flipX) return;
            spriteRenderer.flipX = false;
            if (ShootAndDirectPoints == null) return;
            ShootAndDirectPoints.rotation = fixedRotation;
        }
    }
}
