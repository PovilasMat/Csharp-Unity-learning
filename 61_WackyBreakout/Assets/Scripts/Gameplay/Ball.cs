using UnityEngine;
/// <summary>
/// Scripts that control the ball movement
/// </summary>
public class Ball : MonoBehaviour
{
    float colliderRadius;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // get the ball moving at 20 angle
        float angle = 270;
        Vector2 moveDirection = new Vector2(
            Mathf.Cos(angle * Mathf.Deg2Rad),
            Mathf.Sin(angle * Mathf.Deg2Rad));
        GetComponent<Rigidbody2D>().AddForce(moveDirection * ConfigurationUtils.BallImpulseForce, ForceMode2D.Impulse);

        colliderRadius = GetComponent<CircleCollider2D>().radius;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetDirection(Vector2 direction)
    {
        GetComponent<Rigidbody2D>().linearVelocity = direction * ConfigurationUtils.BallImpulseForce;
    }


}
