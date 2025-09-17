using UnityEngine;

public abstract class Attack : ScriptableObject
{
    [Header("General Attack Properties")]
    public string attackName;
    public float damage;
    public float range;
    public float attackRate;

    public abstract void ExecuteAttack(Transform attacker, Transform target);
}
