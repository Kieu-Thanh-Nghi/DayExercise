using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCollider : MonoBehaviour
{
    [SerializeField] Animator animator;
    DAttackState charAttack;

    private void Start()
    {
        if (animator != null) charAttack = animator.GetBehaviour<DAttackState>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        BodyCollider enemyBody;
        if (collision.gameObject.TryGetComponent<BodyCollider>(out enemyBody))
        {
            enemyBody.GetHurt();
            if (animator != null) charAttack.isHit = true;
        }
    }
}
