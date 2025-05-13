using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public float speed = 2f;          // Kecepatan terbang ke kiri
    public float destroyX = -15f;     // Posisi X di mana burung akan dihancurkan

    void Update()
    {
        // Gerakkan burung ke kiri
        transform.position += Vector3.left * speed * Time.deltaTime;

        // Hancurkan jika keluar layar
        if (transform.position.x < destroyX)
        {
            Destroy(gameObject);
        }
    }
}
