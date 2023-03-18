using System;
using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    public static HealthPlayer InstanceHealthPlayer { get; set; }

    [SerializeField] private int maxHealth = 100;
    public int currentHealth;

    public event Action<float> HealthChanged;

    private void Start()
    {
        InstanceHealthPlayer = this;
        currentHealth = maxHealth;
    }

    public void ChangeHealth(int value)
    {
        currentHealth += value;

        if(currentHealth <= 0)
        {
            Death();
            health();
        }
        else
        {
            health();
        }
    }

    private void health()
    {
        float CurrentHealthAsPercantage = (float)currentHealth / maxHealth;
        HealthChanged?.Invoke(CurrentHealthAsPercantage);
    }

    private void Death()
    {
        Destroy(gameObject);
    }
}
