using UnityEngine;

public class ItemPickedEvent : GameEvent
{
    public string itemId;
    public ItemPickedEvent(string itemId)
    {
        this.itemId = itemId;
    }
}
