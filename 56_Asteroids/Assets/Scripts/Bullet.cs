﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A bullet
/// </summary>
public class Bullet : MonoBehaviour
{
    // death support
    const float LifeSeconds = 2;
    Timer deathTimer;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
	{
		// create and run death timer
        deathTimer = gameObject.AddComponent<Timer>();
        deathTimer.Duration = LifeSeconds;
        deathTimer.Run();
	}
	
	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
		// kill bullet when timer is done
        if (deathTimer.Finished)
        {
            Destroy(gameObject);
        }
	}

    /// <summary>
    /// Applies a force to the bullet in the given direction
    /// </summary>
    /// <param name="forceDirection">force direction</param>
    public void ApplyForce(Vector2 forceDirection)
    {
        const float forceMagnitude = 3;
        GetComponent<Rigidbody2D>().AddForce(
            forceMagnitude * forceDirection * 2,
            ForceMode2D.Impulse);
    }
}
