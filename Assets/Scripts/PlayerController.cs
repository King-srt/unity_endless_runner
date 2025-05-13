using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 5f;         // Kecepatan gerakan horizontal (kiri-kanan)
    public float verticalSpeed = 5f;     // Kecepatan gerakan vertikal (atas-bawah)
    public float xMin = -8f;            // Batas kiri layar
    public float xMax = 8f;             // Batas kanan layar
    public float yMin = -4f;            // Batas bawah layar
    public float yMax = 4f;             // Batas atas layar

    private Rigidbody2D rb;             // Referensi ke Rigidbody2D untuk gerakan berbasis fisika

    void Start()
    {
        // Mendapatkan komponen Rigidbody2D yang sudah ada pada pesawat
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Ambil input untuk gerakan horizontal (kiri-kanan) dan vertikal (atas-bawah)
        float moveX = Input.GetAxis("Horizontal") * moveSpeed;
        float moveY = Input.GetAxis("Vertical") * verticalSpeed;

        // Tentukan gerakan berdasarkan input
        Vector2 movement = new Vector2(moveX, moveY);

        // Terapkan gerakan pada Rigidbody2D
        rb.linearVelocity = movement;

        // Batasi posisi pesawat agar tidak keluar dari layar
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, xMin, xMax);
        clampedPosition.y = Mathf.Clamp(clampedPosition.y, yMin, yMax);

        // Terapkan posisi terbatasi kembali ke objek pesawat
        transform.position = clampedPosition;
    }
}
