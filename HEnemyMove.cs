using UnityEngine;

public class HEnemyMove : MonoBehaviour
{
    [SerializeField] private float HEnemyspeed = 1.0f;

    private void Update()
    {
        transform.Translate(Vector2.down * HEnemyspeed * Time.deltaTime);
    }
}
