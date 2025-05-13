// using UnityEngine;
// using UnityEngine.UI;

// public class ScoreManager : MonoBehaviour
// {
//     public static ScoreManager instance;

//     public int score = 0;
//     public Text scoreText;

//     void Awake()
//     {
//         // Singleton: supaya bisa diakses dari skrip lain
//         if (instance == null)
//         {
//             instance = this;
//         }
//         else
//         {
//             Destroy(gameObject); // Hindari duplikasi
//         }
//     }

//     public void AddScore(int value)
//     {
//         score += value;
//         UpdateScoreText();
//     }

//     void UpdateScoreText()
//     {
//         if (scoreText != null)
//             scoreText.text = "Score: " + score;
//     }
// }

using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int score = 0;
    public int survivalTime = 0; 
    public Text scoreText;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        survivalTime = Mathf.FloorToInt(Time.timeSinceLevelLoad); 
        UpdateScoreText(); // ini akan update teks Passed & Time secara live
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
            scoreText.text = $"Passed : {score}      Time : {survivalTime}";
    }
}



