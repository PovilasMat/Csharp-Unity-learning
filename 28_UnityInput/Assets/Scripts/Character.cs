using UnityEngine;
using UnityEngine.UIElements;

public class Character : MonoBehaviour
{
    float colliderHalfWidth;
    float colliderHalfHeight;

    // movememnt support
    const float MoveUnitsPerSecond = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BoxCollider2D collider = GetComponent<BoxCollider2D>();
        colliderHalfWidth = collider.size.x / 2;
        colliderHalfHeight = collider.size.y / 2;
    }

    // Update is called once per frame
    void Update()
    {
        // convert mouse position to world position
        //Vector3 position = Input.mousePosition;
        //position.z = -Camera.main.transform.position.z;
        //position = Camera.main.ScreenToWorldPoint(position);
        Vector3 position = transform.position;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        if (horizontalInput != 0)
        {
            position.x += horizontalInput * MoveUnitsPerSecond * Time.deltaTime;
        }
        if (verticalInput != 0)
        {
            position.y += verticalInput * MoveUnitsPerSecond * Time.deltaTime;
        }

        // move character
        transform.position = position;
        ClampInScreen();
    }

    /// Clamps the character in the screen
    void ClampInScreen()
    {
        Vector3 position = transform.position;

        // clam horinzontally
        if (position.x - colliderHalfWidth < ScreenUtils.ScreenLeft)
        {
            position.x = ScreenUtils.ScreenLeft + colliderHalfWidth;
        }
        else if (position.x + colliderHalfWidth > ScreenUtils.ScreenRight)
        {
            position.x = ScreenUtils.ScreenRight - colliderHalfWidth;
        }

        // clamp vertically
        if (position.y + colliderHalfHeight > ScreenUtils.ScreenTop)
        {
            position.y = ScreenUtils.ScreenTop - colliderHalfHeight;
        }
        else if (position.y - colliderHalfHeight < ScreenUtils.ScreenBottom)
        {
            position.y = ScreenUtils.ScreenBottom + colliderHalfHeight;
        }

        // set the new position of the character
        transform.position = position;
    }
}
