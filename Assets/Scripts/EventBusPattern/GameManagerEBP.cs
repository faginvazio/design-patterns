using UnityEngine;

public class GameManagerEBP : MonoBehaviour
{
    [SerializeField] private GameObject item;
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            item.GetComponent<ItemEBP>().PickUp();
        }
    }
}
