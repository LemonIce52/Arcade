using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image healthBar;
    [SerializeField] HealthBase health;

    private void Awake()
    {
        health.HealthChangedBase += OnHealthChanged;
    }

    private void OnDestroy()
    {
        health.HealthChangedBase -= OnHealthChanged;
    }

    private void OnHealthChanged(float ValueAsPercantage)
    {
        healthBar.fillAmount = ValueAsPercantage;
    }
}
