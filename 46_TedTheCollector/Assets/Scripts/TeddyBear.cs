using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A collecting teddy bear
/// </summary>
public class TeddyBear : MonoBehaviour
{
	#region Fields

	const float ImpulseForceMagnitude = 2.0f;

	bool collecting = false;
	GameObject targetPickup;

	// saved for efficiency
	Rigidbody2D rb2d;
	TedTheCollector tedTheCollector;

    #endregion

    #region Methods

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
		// center teddy bear in screen
		transform.position = Vector3.zero;

		// save references for efficiency
		rb2d = GetComponent<Rigidbody2D>();
		tedTheCollector = Camera.main.GetComponent<TedTheCollector>();
	}

    /// <summary>
    /// OnMouseDown is called when the user has pressed the mouse button
    /// over the collider
    /// </summary>
    void OnMouseDown()
    {
		// ignore mouse clicks if already collecting
		if (!collecting)
        {
            collecting = true;
            GoToNextPickup();
		}
	}

    /// <summary>
    /// Called when another object is within a trigger collider
    /// attached to this object
    /// </summary>
    /// <param name="other">collider info</param>
    void OnTriggerStay2D(Collider2D other)
    {
		// only respond if the collision is with the target pickup
		if (other.gameObject == targetPickup)
        {
			// remove collected pickup from game and go to the next one
			tedTheCollector.RemovePickup(targetPickup);
			rb2d.linearVelocity = Vector2.zero;
			GoToNextPickup();
		}
	}

    public void UpdateTarget(GameObject pickup)
    {
		if (targetPickup == null)
		{
			SetTarget(pickup);
		}
		else
		{
			float targetDistance = GetDistance(targetPickup);
			if (GetDistance(pickup) < targetDistance)
			{
				SetTarget(pickup);
			}
		}
    }

	float GetDistance(GameObject pickup)
	{
		return Vector3.Distance(transform.position, pickup.transform.position);
	}


	void SetTarget(GameObject pickup)
	{
		targetPickup = pickup;
		if (collecting)
		{
			GoToTargetPickup();
		}
	}

	void GoToTargetPickup()
    {
		// calculate direction to target pickup and start moving toward it
		Vector2 direction = new Vector2(
			targetPickup.transform.position.x - transform.position.x,
			targetPickup.transform.position.y - transform.position.y);
		direction.Normalize();
		rb2d.linearVelocity = Vector2.zero;
		rb2d.AddForce(direction * ImpulseForceMagnitude,
			ForceMode2D.Impulse);
    }
        /// <summary>
        /// Starts the teddy bear moving toward the next pickup
        /// </summary>
    void GoToNextPickup()
    {
		// calculate direction to target pickup and start moving toward it
		targetPickup = GetClosestPickUp();
		if (targetPickup != null)
		{
            GoToTargetPickup();
        }
		else
		{
			collecting = false;
		}
	}

	GameObject GetClosestPickUp()
	{
		// initial setup
		List<GameObject> pickups = tedTheCollector.Pickups;
		GameObject closestPickup;
		float closestDistance;
		if (pickups.Count == 0)
		{
			return null;
		}
		else
		{
			closestPickup = pickups[0];
			closestDistance = GetDistance(closestPickup);
		}

		foreach (GameObject pickup in pickups)
		{
			float distance = GetDistance(pickup);
			if (distance < closestDistance)
			{
				closestPickup = pickup;
				closestDistance = distance;
			}
		}
		return closestPickup;
	}
	#endregion
}
