using UnityEngine;

public class MEnemy : MonoBehaviour
{
    private int health = 5;

    public void takeDamage(int value)
    {
        health -= value;

        if(health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
        Score.Instance.upScore(1);
        MediumMobSpawner.InstanseSpawn.spawn(1);

    }
}
