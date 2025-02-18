using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] GameObject ballPrefab;

    void Awake()
    {
        SpawnBall();
    }

    public void SpawnBall()
    {
        if (ballPrefab == null)
        {
            Debug.LogError("Ball prefab is not assigned.");
            return;
        }
        // Instantiate the ball prefab
        GameObject ball = Instantiate(ballPrefab, new Vector3(0, 2.0f, 0), Quaternion.identity);
        if (ball.GetComponent<Renderer>() == null)
        {
            Debug.LogError("Ball prefab does not have a Renderer component.");
        }
    }
}
