using UnityEngine;

public class HEnemy : MonoBehaviour
{
    private int Hhelth = 4;

    public void TakeDamage(int damage)
    {
        Hhelth -= damage;

        if (Hhelth <= 0)
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
            HealthPlayer.InstanceHealthPlayer.ChangeHealth(-20);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Base")
        {
            HealthBase.InstanceHeathBase.ChangeHealth(-20);
            Destroy(gameObject);
        }
    }
}
