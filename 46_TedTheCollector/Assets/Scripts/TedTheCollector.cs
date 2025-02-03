using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Game manager
/// </summary>
public class TedTheCollector : MonoBehaviour
{
	#region Fields

	[SerializeField]
	GameObject prefabPickup;

	TeddyBear teddyBear;
	List<GameObject> pickups = new List<GameObject>();

	#endregion

	#region Properties
	public List<GameObject> Pickups
    {
        get { return pickups; }
    }

    #endregion

    #region Methods
    private void Start()
    {
		GameObject teddyBearGameObject = GameObject.FindWithTag("TeddyBear");
        teddyBear = teddyBearGameObject.GetComponent<TeddyBear>();
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
		// add pickup on right press
		if (Input.GetMouseButtonDown(1))
        {
			// calculate world position of mouse click
			Vector3 mousePosition = Input.mousePosition;
			mousePosition.z = -Camera.main.transform.position.z;
			Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

			// create pickup and add to list
			GameObject pickup = Instantiate<GameObject>(prefabPickup);
			pickup.transform.position = worldPosition;
			pickups.Add(pickup);

			teddyBear.UpdateTarget(pickup);
        }
	}

	/// <summary>
	/// Removes the given pickup from the game
	/// </summary>
	/// <param name="pickup">the pickup to remove</param>
	public void RemovePickup(GameObject pickup)
    {
		pickups.Remove(pickup);
		Destroy(pickup);
	}

	#endregion
}
