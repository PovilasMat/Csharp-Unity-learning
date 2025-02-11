using UnityEngine;
/// <summary>
/// Scripts that control the ball movement
/// </summary>
public class Ball : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // get the ball moving at 20 angle
        float angle = 270;
        Vector2 moveDirection = new Vector2(
            Mathf.Cos(angle * Mathf.Deg2Rad),
            Mathf.Sin(angle * Mathf.Deg2Rad));
        GetComponent<Rigidbody2D>().AddForce(moveDirection * ConfigurationUtils.BallImpulseForce, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetDirection(Vector2 direction)
    {
        //GetComponent<Rigidbody2D>().linearVelocity = direction * ConfigurationUtils.BallImpulseForce;
        // get current rigidbody speed
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        float speed = rb2d.velocity.magnitude;
        rb2d.velocity = direction * speed;
    }


}
