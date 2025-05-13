using UnityEngine;
using UnityEngine.UI;

public class GameOverDisplay : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject gameOverText;
    public GameObject restartButton;
    public Text scoreTotalText; // <- pakai Text UI Legacy

    void Start()
    {
        Text buttonText = restartButton.GetComponentInChildren<Text>();
        if (buttonText != null)
        {
            buttonText.text = "Restart Game";
        }
    }

    public void ShowGameOver()
    {
        gameOverPanel.SetActive(true);
        gameOverText.SetActive(true);
        restartButton.SetActive(true);
        scoreTotalText.gameObject.SetActive(true); // tampilkan text

        if (scoreTotalText != null)
        {
            int passed = ScoreManager.instance?.score ?? 0;
            int time = ScoreManager.instance?.survivalTime ?? 0;
            int total = passed + time;

            scoreTotalText.text = $"Total Score: {total} (Passed: {passed} + Time: {time})";
        }
    }

    public void HideGameOver()
    {
        gameOverPanel.SetActive(false);
        gameOverText.SetActive(false);
        restartButton.SetActive(false);
        scoreTotalText.gameObject.SetActive(false); // sembunyikan text
    }
}
