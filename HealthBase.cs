using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthBase : MonoBehaviour
{
    public static HealthBase InstanceHeathBase { get; set; }

    [SerializeField] private int maxHealthBase = 100;
    public int currentHealthBase;
    
    public event Action<float> HealthChangedBase;

    private void Start()
    {
        InstanceHeathBase = this;
        currentHealthBase = maxHealthBase;
    }

    public void ChangeHealth(int value)
    {
        currentHealthBase += value;

        if (currentHealthBase <= 0)
        {
            Death();
            healthBase();
        }
        else
        {
            healthBase();
        }
    }

    private void healthBase()
    {
        float CurrentHealthAsPercantageBase = (float)currentHealthBase / maxHealthBase;
        HealthChangedBase?.Invoke(CurrentHealthAsPercantageBase);
    }

    private void Death()
    {
        Destroy(gameObject);
        SceneManager.LoadScene(2);
    }
}
