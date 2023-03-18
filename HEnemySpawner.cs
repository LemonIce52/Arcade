using UnityEngine;

public class HEnemySpawner : MonoBehaviour
{
    [SerializeField] private float timeToSpawn, minXposition, maxXposition;
    [SerializeField] private GameObject HEnemyPrefab;
    private float timer;

    private void Start()
    {
        timer = timeToSpawn;
    }

    private void Update()
    {
        if (timer <= 0)
        {
            if (timeToSpawn >= 9)
            {
                timeToSpawn--;
            }
            timer = timeToSpawn;
            GameObject pipe = Instantiate(HEnemyPrefab, transform.position, Quaternion.identity);
            float rand = Random.Range(minXposition, maxXposition);
            pipe.transform.position = new Vector3(rand, 4, 0);
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
