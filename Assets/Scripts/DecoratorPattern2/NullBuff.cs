using UnityEngine;

public class NullBuff : IBuff
{
    public int Duration { get { return int.MaxValue; } set { } }
    public int GetAttackModifier() => 0;
    public int GetDefenseModifier() => 0;
    public IBuff Tick() => this;
    public IBuff RemoveDecorator<T>() where T : IBuff => this;
}
