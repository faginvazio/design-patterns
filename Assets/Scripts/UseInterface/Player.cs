using UnityEngine;

public class Player : MonoBehaviour, IDamageable
{
    private int health = 150;

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("player takes " + damage + " damage. health: " + health);

        if (health < 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("Player died.");
    }
}
