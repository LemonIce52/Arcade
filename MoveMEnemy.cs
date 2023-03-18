using UnityEngine;

public class MoveMEnemy : MonoBehaviour
{
    [SerializeField] private float speed = 0.5f;

    private void Update()
    {
        if(transform.position.y != 2)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }
}
