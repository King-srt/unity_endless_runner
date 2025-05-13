using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int score = 0;
    public Text scoreText;

    void Awake()
    {
        // Singleton: supaya bisa diakses dari skrip lain
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject); // Hindari duplikasi
        }
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score;
    }
}
