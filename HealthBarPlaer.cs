using UnityEngine;
using UnityEngine.UI;

public class HealthBarPlaer : MonoBehaviour
{
    [SerializeField] private Image healthBarPlayer;
    [SerializeField] HealthPlayer health;

    private void Awake()
    {
        health.HealthChanged += OnHealthChanged;
    }

    private void OnDestroy()
    {
        health.HealthChanged -= OnHealthChanged;
    }

    private void OnHealthChanged(float ValueAsPercantage)
    {
        healthBarPlayer.fillAmount = ValueAsPercantage;
    }

}
