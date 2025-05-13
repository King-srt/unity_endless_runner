using UnityEngine;
using UnityEngine.UI; // Untuk menggunakan UI Text dan Button

public class GameOverDisplay : MonoBehaviour
{
    public GameObject gameOverPanel;    // Panel gelap
    public GameObject gameOverText;     // Teks "Game Over"
    public GameObject restartButton;    // Tombol restart


    void Start()
    {
        // Ganti teks pada button saat Start
        Text buttonText = restartButton.GetComponentInChildren<Text>();
        if (buttonText != null)
        {
            buttonText.text = "Restart Game";
        }
    }

    public void ShowGameOver()
    {
        gameOverPanel.SetActive(true);     // Tampilkan panel gelap + UI
        gameOverText.SetActive(true);
        restartButton.SetActive(true);
    }

    public void HideGameOver()
    {
        gameOverPanel.SetActive(false);    // Sembunyikan panel dan semua isinya
        gameOverText.SetActive(false);
        restartButton.SetActive(false);
    }
}

