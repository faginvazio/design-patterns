using UnityEngine;

public class MemoryGame : GameFlow
{
    protected override void Initialize()
    {
        Debug.Log("Memory setup");
    }

    protected override void Play()
    {
        Debug.Log("Memory game start");
    }

    protected override void Cleanup()
    {
        Debug.Log("Cleanup memory game");        
    }
}
