using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float scrollSpeed = 2f;

    private float backgroundWidth;

    void Start()
    {
        // Mengambil lebar background dari SpriteRenderer
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            backgroundWidth = spriteRenderer.bounds.size.x;
        }
        else
        {
            Debug.LogError("Tidak ada SpriteRenderer pada objek background!");
        }
    }

    void Update()
    {
        // Gerakkan background ke kiri
        transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime);

        // Reset posisi saat background keluar layar
      if (transform.position.x <= -backgroundWidth - 0.02f)
{
    Vector3 newPos = transform.position;
    newPos.x += 2f * backgroundWidth - 0.02f; // geser balik + sedikit overlap
    transform.position = newPos;
}

    }
}
