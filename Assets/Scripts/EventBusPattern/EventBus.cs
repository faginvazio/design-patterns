using System;
using System.Collections.Generic;
using UnityEngine;

public static class EventBus
{
    private static Dictionary<Type, Action<GameEvent>> eventTable = new();

    public static void Subscribe<T>(Action<T> callback) where T : GameEvent
    {
        Type type = typeof(T);
        if (!eventTable.ContainsKey(type))
        {
            eventTable[type] = delegate { };
        }
        eventTable[type] += (e) => callback((T)e);
    }

    public static void Unsubscribe<T>(Action<T> callback) where T : GameEvent
    {
        Type type = typeof(T);
        if (eventTable.ContainsKey(type))
        {
            eventTable[type] -= (e) => callback((T)e);
        }
    }

    public static void Publish(GameEvent e)
    {
        Type type = e.GetType();
        if (eventTable.ContainsKey(type))
        {
            eventTable[type]?.Invoke(e);
        }
    }
}