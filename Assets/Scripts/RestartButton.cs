using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    // Fungsi ini akan dipanggil saat tombol Restart ditekan
    public void Restart()
    {
        Time.timeScale = 1f; // Mengembalikan waktu ke normal (menghentikan pause)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Memuat ulang scene saat ini
    }
}
