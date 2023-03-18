using UnityEngine;

public class Lazer : MonoBehaviour
{
    [SerializeField] private float lazerSpeed = 20f;
    [SerializeField] private Rigidbody2D lazerFizix;

    void Start()
    {
        lazerFizix.velocity = transform.right * lazerSpeed;
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
