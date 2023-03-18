using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    [SerializeField] private Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        HealthBoutel boutel = collision.GetComponent<HealthBoutel>();
        MEnemy menemy = collision.GetComponent<MEnemy>();
        HEnemy henemy = collision.GetComponent<HEnemy>();

        if(enemy != null)
        {
            enemy.TakeDamage(1);
        }

        if(boutel != null)
        {
            boutel.takeDamage(1);
        }

        if(menemy != null)
        {
            menemy.takeDamage(1);
        }

        if(henemy != null)
        {
            henemy.TakeDamage(1);
        }

        Destroy(gameObject);
    }
}
