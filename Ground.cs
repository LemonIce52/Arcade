using UnityEngine;
using UnityEngine.UI;

public class Ground : MonoBehaviour
{
    [SerializeField] Sprite bg1;
    [SerializeField] Sprite bg2;
    [SerializeField] Sprite bg3;
    [SerializeField] Sprite bg4;
    [SerializeField] Sprite bg5;
    [SerializeField] private Image backGround;
    [SerializeField] private GameObject panel;

    public void buttonBG1()
    {
        backGround.sprite = bg1;
        panel.SetActive(false);
        Time.timeScale = 1;
    }

    public void buttonBG2()
    {
        backGround.sprite = bg2;
        panel.SetActive(false);
        Time.timeScale = 1;
    }

    public void buttonBG3()
    {
        backGround.sprite = bg3;
        panel.SetActive(false);
        Time.timeScale = 1;
    }

    public void buttonBG4()
    {
        backGround.sprite = bg4;
        panel.SetActive(false);
        Time.timeScale = 1;
    }

    public void buttonBG5()
    {
        backGround.sprite = bg5;
        panel.SetActive(false);
        Time.timeScale = 1;
    }
}
