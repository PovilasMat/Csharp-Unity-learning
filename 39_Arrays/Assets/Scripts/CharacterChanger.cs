using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Changes character on left mouse button
/// </summary>
public class CharacterChanger : MonoBehaviour
{
    //GameObject[] prefabCharacters = new GameObject[4];
    List<GameObject> prefabCharacters = new List<GameObject>();

    // need for location of new character
    GameObject currentCharacter;

    // first frame input support
    bool previousChangeCharacterInput = false;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start()
    {
        // populate character prefab array
        //prefabCharacters[0] = Resources.Load<GameObject>(@"Prefabs\HunterMan");
        //prefabCharacters[1] = Resources.Load<GameObject>("Prefabs/MinerMan");
        //prefabCharacters[2] = Resources.Load<GameObject>("Prefabs/PioneerWoman");
        //prefabCharacters[3] = Resources.Load<GameObject>("Prefabs/SkunkWoman");

        //populate character prefab list
        prefabCharacters.Add(Resources.Load<GameObject>(@"Prefabs\HunterMan"));
        prefabCharacters.Add(Resources.Load<GameObject>("Prefabs/MinerMan"));
        prefabCharacters.Add(Resources.Load<GameObject>("Prefabs/PioneerWoman"));
        prefabCharacters.Add(Resources.Load<GameObject>("Prefabs/SkunkWoman"));

        currentCharacter = Instantiate<GameObject>(
            prefabCharacters[0], Vector3.zero,
            Quaternion.identity);
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        // change character on left mouse button
        if (Input.GetAxis("ChangeCharacter") > 0)
        {
            if (!previousChangeCharacterInput)
            {
                previousChangeCharacterInput = true;

                // save position and destroy current character
                Vector3 position = currentCharacter.transform.position;
                Destroy(currentCharacter);

                // instantiate new character
                currentCharacter = Instantiate<GameObject>(
                    prefabCharacters[Random.Range(0, 4)], position, Quaternion.identity);
            }
        }
        else
        {
            // no change character input
            previousChangeCharacterInput = false;
        }
    }
}
