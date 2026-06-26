using TMPro;
using UnityEngine;

public class InventotyUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI inventoryItemText;

    private void OnEnable()
    {
        EventBus.Subscribe<ItemPickedEvent>(OnItemPicked);
    }
    private void OnDisable()
    {
        EventBus.Unsubscribe<ItemPickedEvent>(OnItemPicked);
    }

    private void OnItemPicked(ItemPickedEvent e)
    {
        Debug.Log($"item: {e.itemId}");
        inventoryItemText.text = "Item:" + e.itemId;
    }
}
