using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 8f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private GameObject panel;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);

        if (Input.GetKey(KeyCode.Escape))
        {
            panel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
