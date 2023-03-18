using UnityEngine.UI;
using UnityEngine;

public class Achivments : MonoBehaviour
{
    private int monsterKill;
    [SerializeField] private GameObject lock1;
    [SerializeField] private GameObject lock2;
    [SerializeField] private GameObject lock3;
    [SerializeField] private GameObject Unlock1;
    [SerializeField] private GameObject Unlock2;
    [SerializeField] private GameObject Unlock3;

    private void Awake()
    {
        monsterKill = PlayerPrefs.GetInt("Score");
    }

    private void Update()
    {
        if(monsterKill >= 10)
        {
            lock1.SetActive(false);
            Unlock1.SetActive(true);
        }

        if(monsterKill >= 100)
        {
            lock2.SetActive(false);
            Unlock2.SetActive(true);
        }

        if(monsterKill >= 500)
        {
            lock3.SetActive(false);
            Unlock3.SetActive(true);
        }
    }
}
