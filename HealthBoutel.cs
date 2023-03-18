using UnityEngine;

public class HealthBoutel : MonoBehaviour
{
    private int heathBoutle = 1;

    public void takeDamage(int value)
    {
        heathBoutle -= value;

        if(heathBoutle == 0)
        {
            die();
        }
    }

    private void die()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        int health = HealthPlayer.InstanceHealthPlayer.currentHealth;
        int healthBase = HealthBase.InstanceHeathBase.currentHealthBase;

        if (collision.gameObject.tag == "Player")
        {
            if (health != 100)
            {
                HealthPlayer.InstanceHealthPlayer.ChangeHealth(10);
            }
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Base")
        {
            if (healthBase != 100)
            {
                HealthBase.InstanceHeathBase.ChangeHealth(10);
            }
            Destroy(gameObject);
        }
    }
}
