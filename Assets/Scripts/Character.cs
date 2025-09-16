using UnityEngine;

public class Character : Billboard
{
    public enum CharacterType { Player, NPC, Enemy };

    [SerializeField] private string characterName;
    [SerializeField] private float health;
    [SerializeField] private float moveSpeed;
    [SerializeField] private Animator animator;
}
