using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] GameObject ballPrefab;
    Timer randomSpawnTimer;

    bool retrySpawn = false;
    Vector2 spawnLocationMin;
    Vector2 spawnLocationMax;

    void Awake()
    {
        SpawnBall();
    }

    void Start()
    {
        GameObject tempBall = Instantiate<GameObject>(ballPrefab);
        BoxCollider2D collider = tempBall.GetComponent<BoxCollider2D>();
        float ballColliderHalfWidth = collider.size.x / 2;
        float ballColliderHalfHeight = collider.size.y / 2;
        spawnLocationMin = new Vector2(
            tempBall.transform.position.x - ballColliderHalfWidth,
            tempBall.transform.position.y - ballColliderHalfHeight);
        spawnLocationMax = new Vector2(
            tempBall.transform.position.x + ballColliderHalfWidth,
            tempBall.transform.position.y + ballColliderHalfHeight);
        Destroy(tempBall);

        randomSpawnTimer = gameObject.AddComponent<Timer>();
        SetRandomSpawnTimer();
    }

    void Update()
    {
        if (retrySpawn)
        {
            SpawnBall();
        }
        if (randomSpawnTimer.Finished)
        {
            SpawnBall();
            SetRandomSpawnTimer();
        }
    }

    public void SpawnBall()
    {
        if (ballPrefab == null)
        {
            Debug.LogError("Ball prefab is not assigned.");
            return;
        }

        // Define static spawn position
        Vector2 spawnPosition = new Vector2(0, 2.0f); // Change this to your desired static position

        // Check for overlap at the spawn position
        Collider2D overlapCollider = Physics2D.OverlapArea(
            new Vector2(spawnPosition.x - ballPrefab.GetComponent<BoxCollider2D>().size.x / 2, spawnPosition.y - ballPrefab.GetComponent<BoxCollider2D>().size.y / 2),
            new Vector2(spawnPosition.x + ballPrefab.GetComponent<BoxCollider2D>().size.x / 2, spawnPosition.y + ballPrefab.GetComponent<BoxCollider2D>().size.y / 2)
        );

        if (overlapCollider == null)
        {
            retrySpawn = false;
            Instantiate(ballPrefab, spawnPosition, Quaternion.identity);
        }
        else
        {
            retrySpawn = true;
        }
    }

    public void SetRandomSpawnTimer()
    {
        randomSpawnTimer.Duration = Random.Range(ConfigurationUtils.ballMinSpawnTimer, ConfigurationUtils.ballMaxSpawnTimer);
        randomSpawnTimer.Run();
    }
}
