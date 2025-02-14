using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A teddy bear
/// </summary>
public class TeddyBear : MonoBehaviour
{
    AudioSource audioSource;

    /// <summary>
	/// Start is called before the first frame update
	/// </summary>	
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    /// <summary>
    /// Play sound when mouse enters collider
    /// </summary>
    void OnMouseEnter()
    {
        audioSource.Play();
    }
}
