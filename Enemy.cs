using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int helth = 1;

    public void TakeDamage(int damage)
    {
        helth -= damage;

        if(helth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        Score.Instance.upScore(1);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            HealthPlayer.InstanceHealthPlayer.ChangeHealth(-10);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Base")
        {
            HealthBase.InstanceHeathBase.ChangeHealth(-10);
            Destroy(gameObject);
        }
    }
}
