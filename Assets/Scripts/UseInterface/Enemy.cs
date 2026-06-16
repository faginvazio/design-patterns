using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    private int health = 80;
    
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Enemy takes " +  damage + " damage. health: " + health);

        if (health < 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("Enemy died");
    }
}
