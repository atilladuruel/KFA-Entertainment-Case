using UnityEngine;

public class Player : Character
{
    public CharacterType CharacterType { get { return characterType; } }

    private CharacterType characterType = CharacterType.Player;
}
