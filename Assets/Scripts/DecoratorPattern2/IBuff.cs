using UnityEngine;

public interface IBuff
{
    public int Duration { get; set; }

    public int GetAttackModifier();

    public int GetDefenseModifier();

    public IBuff Tick();

    // I do not get this syntax right now
    // where T : IBuff (the generic constraint)
    public IBuff RemoveDecorator<T>() where T : IBuff;
    
}
