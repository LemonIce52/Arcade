using UnityEngine;

public class MoveBoutel : MonoBehaviour
{
    [SerializeField] private float speed = 4f;

    private void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
}
