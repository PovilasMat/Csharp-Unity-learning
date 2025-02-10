using UnityEngine;

public class Paddle : MonoBehaviour
{
    Rigidbody2D rb2d;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
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

        rb2d.MovePosition(position);
    }
}
