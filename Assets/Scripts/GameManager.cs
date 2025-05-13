// using UnityEngine;
// using UnityEngine.UI;
// using UnityEngine.SceneManagement; // Untuk restart scene

// public class GameManager : MonoBehaviour
// {
//     public GameOverDisplay gameOverDisplay; // Skrip untuk mengendalikan UI Game Over
//     public Text scoreText;                  // Referensi ke UI Text yang menampilkan skor

//     void Start()
//     {
//         // Mulai permainan dengan menyembunyikan Game Over dan tombol restart
//         gameOverDisplay.gameOverText.SetActive(false);
//         gameOverDisplay.restartButton.SetActive(false);
//     }

//     // Fungsi untuk menampilkan Game Over dan tombol restart
//     public void GameOver()
//     {
//         // Menampilkan Game Over dan tombol restart
//         gameOverDisplay.ShowGameOver();

//         // Pause game
//         Time.timeScale = 0f;
//     }

//     // Fungsi untuk restart game
//     public void RestartGame()
//     {
//         Time.timeScale = 1f; // Mengaktifkan kembali waktu
//         SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Memuat ulang scene
//     }
// }


using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameOverDisplay gameOverDisplay;

    void Start()
    {   
        gameOverDisplay.HideGameOver(); // Sembunyikan semua di awal
    }

    public void GameOver()
    {
        gameOverDisplay.ShowGameOver(); // Munculkan semua saat game over
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

