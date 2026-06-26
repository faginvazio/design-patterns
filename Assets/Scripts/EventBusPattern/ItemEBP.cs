using UnityEngine;

public class ItemEBP : MonoBehaviour
{
    public string itemId;

    public void PickUp()
    {
        EventBus.Publish(new ItemPickedEvent(itemId));
        Destroy(gameObject);
    }
}
