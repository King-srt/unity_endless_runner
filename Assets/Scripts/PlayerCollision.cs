using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameManager gameManager;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            gameManager.GameOver(); // Ini yang trigger panel
        }
    }
}
