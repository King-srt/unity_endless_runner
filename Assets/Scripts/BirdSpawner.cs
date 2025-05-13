using UnityEngine;

public class BirdSpawner : MonoBehaviour
{
    public GameObject birdPrefab;
    public float spawnInterval = 2f;
    public float yRange = 3f;
    public float spawnX = 10f;

    public float initialSpeed = 2f;
    private float currentSpeed;

    private float elapsedTime = 0f;
    private float speedIncreaseInterval = 10f;
    private float speedIncreaseAmount = 0.1f;

    void Start()
    {
        currentSpeed = initialSpeed;
        InvokeRepeating("SpawnBirdGroup", 0f, spawnInterval);
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;

        // Tambah kecepatan tiap 20 detik
        if ((int)(elapsedTime) % (int)speedIncreaseInterval == 0)
        {
            currentSpeed = initialSpeed + Mathf.Floor(elapsedTime / speedIncreaseInterval) * speedIncreaseAmount;
        }
    }

    void SpawnBirdGroup()
    {
        int birdCount = GetBirdCountBasedOnTime();

        for (int i = 0; i < birdCount; i++)
        {
            Vector2 spawnPosition = GetRandomSpawnPosition(i);
            float speedVariation = Random.Range(-0.2f, 0.2f); // Variasi kecepatan
            InstantiateBird(spawnPosition, currentSpeed + speedVariation);
        }
    }

    int GetBirdCountBasedOnTime()
    {
        if (elapsedTime < 60f)
            return Random.Range(1, 3); // 1-2 burung
        else if (elapsedTime < 120f)
            return Random.Range(1, 3); // 1-3 burung
        else
            return Random.Range(1, 4); // 1-4 burung
    }

    Vector2 GetRandomSpawnPosition(int index)
    {
        int formationType = Random.Range(0, 3);

        // Distribusi y yang lebih seimbang
        float rawY = Random.value;
        float baseY;
        if (rawY < 0.33f)
            baseY = Random.Range(-yRange, -yRange * 0.6f); // Bawah
        else if (rawY > 0.66f)
            baseY = Random.Range(yRange * 0.6f, yRange);   // Atas
        else
            baseY = Random.Range(-yRange * 0.4f, yRange * 0.4f); // Tengah

        float yOffset = Random.Range(0.5f, 1.5f);
        float xOffset = Random.Range(0.5f, 2f);

        switch (formationType)
        {
            case 0: return new Vector2(spawnX, baseY + index * yOffset);        // Vertikal
            case 1: return new Vector2(spawnX - index * xOffset, baseY);        // Horizontal
            default:
                float y = baseY + Random.Range(-0.3f, 0.3f); // Acakan kecil
                float x = spawnX - Random.Range(0f, 2f);
                return new Vector2(x, y);
        }
    }

    void InstantiateBird(Vector2 spawnPosition, float speed)
    {
        GameObject bird = Instantiate(birdPrefab, spawnPosition, Quaternion.identity);

        Rigidbody2D rb = bird.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            rb.linearVelocity = new Vector2(-speed, 0f);
        }

        if (bird.GetComponent<Collider2D>() == null)
        {
            Debug.LogWarning("Burung tidak memiliki Collider2D!");
        }
    }
}
