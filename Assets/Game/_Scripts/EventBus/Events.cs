public interface IEvent
{
}

public struct TestEvent : IEvent
{
}

public struct PlayerEvent : IEvent
{
    public int health;
    public int mana;
}

public struct PlayerAbilityUsedEvent : IEvent
{
    public string AbilityName;
    public override string ToString() => $"Player used {AbilityName} ability";
}