using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

/// <summary>
/// A ball
/// </summary>	
public class Ball : MonoBehaviour
{
    Timer timer;
    Timer startTimer;
    float angle = -90 * Mathf.Deg2Rad;
    Vector2 force;

    #region Unity methods

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>	
    void Start()
    {
        // get the ball moving
        GetComponent<Rigidbody2D>().AddForce(force);

        timer = gameObject.AddComponent<Timer>();
        timer.Duration = ConfigurationUtils.ballDeathTimer;
        timer.Run();

        startTimer = gameObject.AddComponent<Timer>();
        startTimer.Duration = ConfigurationUtils.ballStartTimer;
        startTimer.Run();
    }

    /// <summary>
	/// Update is called once per frame
	/// </summary>	
    void Update()
    {
        force = new Vector2(
            ConfigurationUtils.BallImpulseForce * Mathf.Cos(angle),
            ConfigurationUtils.BallImpulseForce * Mathf.Sin(angle));

        if (timer != null && timer.Finished)
        {
            Camera.main.GetComponent<BallSpawner>().SpawnBall();
            Destroy(gameObject);
        }

        if (startTimer != null && startTimer.Finished)
        {
            // if ball is not moving
            if (GetComponent<Rigidbody2D>().linearVelocity.magnitude == 0)
            {
                // get the ball moving
                GetComponent<Rigidbody2D>().AddForce(force);
            }
        }
    }

    #endregion

    #region Public methods

    /// <summary>
    /// Sets the ball direction to the given direction
    /// </summary>
    /// <param name="direction">direction</param>
    public void SetDirection(Vector2 direction)
    {
        // get current rigidbody speed
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        float speed = rb2d.linearVelocity.magnitude;
        rb2d.linearVelocity = direction * speed;
    }

    #endregion
}
