using UnityEngine;

public class MEnemyShoot : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject lazerPrefab;
    [SerializeField] private float timeFire;
    private float timer;

    private void Start()
    {
        timer = timeFire;
    }

    private void Update()
    {
        if(timer <= 0)
        {
            timer = timeFire;
            Instantiate(lazerPrefab, firePoint.position, firePoint.rotation);
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
