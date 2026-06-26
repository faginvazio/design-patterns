using UnityEngine;

public class PlayerOP : MonoBehaviour
{
    private PlayerHealth playerHealth;

    private void Start()
    {
        playerHealth = GetComponent<PlayerHealth>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            playerHealth.TakeDamage(1);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            playerHealth.Heal(2);
        }
    }
}