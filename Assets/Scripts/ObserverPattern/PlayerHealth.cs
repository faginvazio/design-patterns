using JetBrains.Annotations;
using System;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public event Action<int, int> OnHealthChanged;

    private int currentHealth;
    private int maxHeath = 100;

    private void Start()
    {
        currentHealth = maxHeath;
    }

    public void TakeDamage(int amount)
    {
        currentHealth = Mathf.Max(currentHealth - amount, 0);
        OnHealthChanged?.Invoke(currentHealth, maxHeath);
    }

    public void Heal(int amount)
    {
        currentHealth = Mathf.Min(currentHealth + amount, maxHeath);
        OnHealthChanged?.Invoke(currentHealth, maxHeath);
    }
}
