using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Processes mouse button inputs
/// </summary>
public class MouseButtonProcessor : MonoBehaviour
{
    [SerializeField]
    GameObject prefabExplosion;
    [SerializeField]
    GameObject prefabTeddyBear;

    // first frame input support
    bool spawnInputOnPreviousFrame = false;
	bool explodeInputOnPreviousFrame = false;

	/// <summary>
	/// Update is called once per frame
	/// </summary>
	  void Update()
    {
        // spawn teddy bear as appropriate
        if (Input.GetAxis("SpawnTeddyBear") > 0)
        {
            if (!spawnInputOnPreviousFrame)
            {
                //transform the mouse position to world position
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePosition.z = -Camera.main.transform.position.z; // Ensure the z position is set to 0
                Instantiate(prefabTeddyBear, mousePosition, Quaternion.identity);
            }
            spawnInputOnPreviousFrame = true;
        }
        else
        {
            spawnInputOnPreviousFrame = false;
        }

        // explode teddy bear as appropriate
        if (Input.GetAxis("ExplodeTeddyBear") > 0)
        {
            if (!explodeInputOnPreviousFrame)
            {
                // find the teddy bear to explode
                GameObject teddyBear = GameObject.FindWithTag("TeddyBear");
                if (teddyBear != null)
                {
                    // explode the teddy bear
                    Instantiate(prefabExplosion, teddyBear.transform.position, Quaternion.identity);
                    Destroy(teddyBear);
                }
            }
            explodeInputOnPreviousFrame = true;
        }
        else
        {
            explodeInputOnPreviousFrame = false;
        }
    }
}
