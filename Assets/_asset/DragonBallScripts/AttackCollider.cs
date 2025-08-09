using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCollider : MonoBehaviour
{
    [SerializeField] CharAttack charAttack;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        BodyCollider enemyBody;
        if (collision.gameObject.TryGetComponent<BodyCollider>(out enemyBody))
        {
            enemyBody.GetHurt();
            if (charAttack != null && charAttack.isActiveAndEnabled) charAttack.isHit = true;
        }
    }
}
