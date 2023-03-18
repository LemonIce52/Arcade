using UnityEngine;

public class MediumMobSpawner : MonoBehaviour
{
    public static MediumMobSpawner InstanseSpawn { get; set; }
     
    [SerializeField] private float timeToSpawn, minXposition, maxXposition;
    [SerializeField] private GameObject MEnemyPrefab;
    private float timer;
    private int spawnMod = 0;

    private void Start()
    {
        InstanseSpawn = this;
        timer = timeToSpawn;
    }

    private void Update()
    {
        if (spawnMod != 1)
        {
            if (timer <= 0)
            {
                if (timeToSpawn >= 4)
                {
                    timeToSpawn--;
                }
                timer = timeToSpawn;
                GameObject pipe = Instantiate(MEnemyPrefab, transform.position, Quaternion.identity);
                float rand = Random.Range(minXposition, maxXposition);
                pipe.transform.position = new Vector3(rand, 4, 0);
                spawnMod++;
            }
            else
            {
                timer -= Time.deltaTime;
            }
        }
    }

    public void spawn(int value)
    {
        spawnMod -= value;
    }
}
