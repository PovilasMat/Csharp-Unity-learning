using UnityEngine;

public class Paddle : MonoBehaviour
{
    Rigidbody2D rb2d;
    float halfColliderWidth;
    float BounceAngleHalfRange;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        halfColliderWidth = GetComponent<BoxCollider2D>().size.x / 2;

        BounceAngleHalfRange = Mathf.PI / 3;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        Vector2 position = rb2d.position;
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            position.x -= ConfigurationUtils.PaddleMoveUnitsPerSecond * Time.fixedDeltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            position.x += ConfigurationUtils.PaddleMoveUnitsPerSecond * Time.fixedDeltaTime;
        }
        position.x = CalculateClampedX(position.x);
        rb2d.MovePosition(position);
    }

    float CalculateClampedX(float possibleX)
    {
        float halfPaddleWidth = halfColliderWidth * transform.localScale.x;
        return Mathf.Clamp(possibleX, ScreenUtils.ScreenLeft + halfPaddleWidth, ScreenUtils.ScreenRight - halfPaddleWidth);
    }

    /// <summary>
    /// Detects collision with a ball to aim the ball
    /// </summary>
    /// <param name="coll">collision info</param>
    void OnCollisionEnter2D(Collision2D coll)
    {


        if (coll.gameObject.CompareTag("Ball") && TopCollisionCheck(coll))
        {
            // calculate new ball direction
            float ballOffsetFromPaddleCenter = transform.position.x -
                coll.transform.position.x;
            float normalizedBallOffset = ballOffsetFromPaddleCenter /
                halfColliderWidth;
            float angleOffset = normalizedBallOffset * BounceAngleHalfRange;
            float angle = Mathf.PI / 2 + angleOffset;
            Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));

            // tell ball to set direction to new direction
            Ball ballScript = coll.gameObject.GetComponent<Ball>();
            ballScript.SetDirection(direction);
        }
    }

    bool TopCollisionCheck(Collision2D coll)
    {
        ContactPoint2D[] contacts = new ContactPoint2D[2];
        coll.GetContacts(contacts);

        foreach (var contact in contacts)
        {
            if (contact.point.y > transform.position.y)
            {
                return true;
            }
        }
        return false;
    }
}
