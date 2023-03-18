using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene : MonoBehaviour
{
    [SerializeField] private GameObject panel;

    public void Home()
    {
        SceneManager.LoadScene(0);
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 0;
    }

    public void Achivment()
    {
        SceneManager.LoadScene(3);
    }

    public void GameMenu()
    {
        panel.SetActive(true);
        Time.timeScale = 0;
    }

    public void falseGameMenu()
    {
        panel.SetActive(false);
        Time.timeScale = 1;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
