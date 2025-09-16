using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSO", menuName = "Game/Player")]
public class PlayerSO : ScriptableObject
{
    [Header("Stats")]
    public string playerName = "Hero";
    public int maxHealth = 100;
    public float moveSpeed = 5f;
    public float attackRange = 2f;
    public float attackDamage = 10f;
    public float attackRate = 1f; // saniyede 1 vuruþ
    public float iFrameDuration = 1f;

    [Header("Extra")]
    public bool rangedAttack = false;
    public GameObject projectilePrefab;
}
