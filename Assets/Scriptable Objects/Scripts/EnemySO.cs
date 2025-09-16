using UnityEngine;

[CreateAssetMenu(fileName = "EnemySO", menuName = "Game/Enemy")]
public class EnemySO : ScriptableObject
{
    [Header("General Info")]
    public string enemyName;
    public Color enemyColor;

    [Header("Stats")]
    public int maxHealth;
    public float moveSpeed;
    public float attackDamage;
    public float attackRate; 
}
