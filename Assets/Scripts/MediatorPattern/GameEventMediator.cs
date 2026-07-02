
using System.Collections.Generic;

public class GameEventMediator
{
    private List<IGameEventReceiver> receivers = new();

    public void Register(IGameEventReceiver receiver)
    {
        receivers.Add(receiver);
    }

    public void Send(IGameEvent gameEvent)
    {
        foreach (var receiver in receivers) 
        {
            receiver.OnGameEvent(gameEvent);
        }
    }
}
