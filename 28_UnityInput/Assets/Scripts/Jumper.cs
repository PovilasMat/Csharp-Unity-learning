using UnityEngine;

public class Jumper : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            // jump on right mouse button press
            // convert mouse position to world position
            Vector3 position = Input.mousePosition;
            position.z = -Camera.main.transform.position.z;
            position = Camera.main.ScreenToWorldPoint(position);

            // move character
            transform.position = position;
        }
    }
}
