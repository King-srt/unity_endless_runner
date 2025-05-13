using UnityEngine;

public class BirdTrigger : MonoBehaviour
{
    private bool hasScored = false;
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player")?.transform;
    }

    void Update()
    {
        if (player != null && !hasScored && transform.position.x < player.position.x)
        {
            hasScored = true;
            ScoreManager.instance?.AddScore(1);
        }
    }
}
