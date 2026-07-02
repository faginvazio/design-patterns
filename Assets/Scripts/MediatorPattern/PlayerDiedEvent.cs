using UnityEngine;

public class PlayerDiedEvent : IGameEvent
{
    public GameEventType EventType => GameEventType.PlayerDied;

    public Vector3 deathPosition;
    public string reason;

    public PlayerDiedEvent(Vector3 pos, string reason)
    {
        deathPosition = pos;
        this.reason = reason;
    }
}
