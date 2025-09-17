
using UnityEngine;

[CreateAssetMenu(fileName = "MeleeAttack", menuName = "Game/Attacks/Melee")]
public class BasicAttack : Attack
{
    public override void ExecuteAttack(Transform attacker, Transform target)
    {
        if (target == null) return;

        // Damage uygulama
        Health targetHealth = target.GetComponent<Health>();
        if (targetHealth != null)
        {
            targetHealth.TakeDamage(damage);
        }
    }
}
