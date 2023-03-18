using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] private float timeToSpawn, minXposition, maxXposition;
    [SerializeField] private GameObject ItemPrefab;
    private float timer;

    private void Start()
    {
        timer = timeToSpawn;
    }

    private void Update()
    {
        if (timer <= 0)
        {
            timer = timeToSpawn;
            GameObject pipe = Instantiate(ItemPrefab, transform.position, Quaternion.identity);
            float rand = Random.Range(minXposition, maxXposition);
            pipe.transform.position = new Vector3(rand, 4, 0);
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
