using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float speed = 1.5f;

    private void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}
