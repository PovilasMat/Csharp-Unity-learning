﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

/// <summary>
/// An asteroid
/// </summary>
public class Asteroid : MonoBehaviour
{
    [SerializeField]
    Sprite asteroidSprite0;
    [SerializeField]
    Sprite asteroidSprite1;
    [SerializeField]
    Sprite asteroidSprite2;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
	{
        // set random sprite for asteroid
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        int spriteNumber = Random.Range(0, 3);
        if (spriteNumber < 1)
        {
            spriteRenderer.sprite = asteroidSprite0;
        }
        else if (spriteNumber < 2)
        {
            spriteRenderer.sprite = asteroidSprite1;
        }
        else
        {
            spriteRenderer.sprite = asteroidSprite2;
        }
	}

    /// <summary>
    /// Starts the asteroid moving in the given direction
    /// </summary>
    /// <param name="direction">direction for the asteroid to move</param>
    /// <param name="position">position for the asteroid</param>
    public void Initialize(Direction direction, Vector3 position)
    {
        // set asteroid position
        transform.position = position;

        // set random angle based on direction
        float angle;
        float randomAngle = Random.value * 30f * Mathf.Deg2Rad;
        if (direction == Direction.Up)
        {
            angle = 75 * Mathf.Deg2Rad + randomAngle;
        }
        else if (direction == Direction.Left)
        {
            angle = 165 * Mathf.Deg2Rad + randomAngle;
        }
        else if (direction == Direction.Down)
        {
            angle = 255 * Mathf.Deg2Rad + randomAngle;
        }
        else
        {
            angle = -15 * Mathf.Deg2Rad + randomAngle;
        }

        StartMoving(angle);
    }

    /// <summary>
    /// Destroys the asteroid on collision with a bullet
    /// </summary>
    /// <param name="coll">collision info</param>
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Bullet"))
        {
            Destroy(coll.gameObject);
            //Destroy(gameObject);
            // reduce the scale of the asteroid
            Vector2 currentScale = transform.localScale;
            if (currentScale.x <= 0.25f)
            {
                Destroy(gameObject);
            }
            else
            {
                
                currentScale.x *= 0.5f;
                currentScale.y *= 0.5f;
                GameObject halfAsteroid = Instantiate(gameObject);
                float randomAngle = Random.Range(0, 2 * Mathf.PI);
                halfAsteroid.GetComponent<CircleCollider2D>().radius *= 0.5f;
                halfAsteroid.transform.localScale = currentScale;
                halfAsteroid.GetComponent<Asteroid>().StartMoving(randomAngle);
                GameObject halfAsteroid2 = Instantiate(gameObject);
                halfAsteroid2.GetComponent<CircleCollider2D>().radius *= 0.5f;
                halfAsteroid2.transform.localScale = currentScale;
                halfAsteroid2.GetComponent<Asteroid>().StartMoving(2 * Mathf.PI - randomAngle);
                Destroy(gameObject);
                //transform.localScale = currentScale; // example scale reduction
                //gameObject.GetComponent<CircleCollider2D>().radius *= 0.5f;
            }
        }
    }

    public void StartMoving(float angle)
    {
        // apply impulse force to get asteroid moving
        const float MinImpulseForce = 1f;
        const float MaxImpulseForce = 3f;
        Vector2 moveDirection = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(
            moveDirection * magnitude,
            ForceMode2D.Impulse);
    }
}
