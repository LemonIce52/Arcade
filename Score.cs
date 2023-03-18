using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score Instance { get; set; }
    
    [SerializeField] private TextMeshProUGUI _scoreText;
    [SerializeField] private TextMeshProUGUI hightScoreText;

    public int hightScore;
    public int score;

    private void Awake()
    {
        Instance = this;
        hightScore = PlayerPrefs.GetInt("Score");
        upScore(0);
    }

    private void Update()
    {
        if(score >= hightScore)
        {
            hightScore = score;
        }
        hightScoreText.text = "Hight Score: " + hightScore;
        PlayerPrefs.SetInt("Score", hightScore);
        PlayerPrefs.Save();
    }

    public void upScore(int score)
    {
        this.score += score;
        _scoreText.text = "Score: " + this.score;
    }

   
}
