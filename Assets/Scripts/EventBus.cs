using System;
using System.Collections.Generic;

public static class EventBus
{
    public static event Action<Attack> OnAttackAdded;

    public static void AddAttack(Attack newAttack)
    {
        OnAttackAdded?.Invoke(newAttack);
    }
}
