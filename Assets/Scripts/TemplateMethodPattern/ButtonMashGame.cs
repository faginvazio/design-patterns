using UnityEngine;

public class ButtonMashGame : MiniGameBase
{
    protected override void Play()
    {
        Debug.Log("player clicks button");
    }

    protected override void Setup()
    {
        Debug.Log("button mash game setup");
    }
}
