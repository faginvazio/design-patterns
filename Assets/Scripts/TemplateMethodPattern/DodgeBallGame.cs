using UnityEngine;

public class DodgeBallGame : MiniGameBase
{
    protected override void Play()
    {
        Debug.Log("start ball");
    }

    protected override void Setup()
    {
        Debug.Log("dodge ball game setup");
    }

    protected override void End()
    {
        base.End();
        Debug.Log("specific end event");
    }
}
