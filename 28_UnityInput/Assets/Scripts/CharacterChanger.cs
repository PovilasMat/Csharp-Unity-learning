using UnityEngine;

public class CharacterChanger : MonoBehaviour
{
    [SerializeField] GameObject characterPrefab0;
    [SerializeField] GameObject characterPrefab1;
    [SerializeField] GameObject characterPrefab2;
    [SerializeField] GameObject characterPrefab3;

    // need for location of new character
    GameObject currentCharacter;

    // first frame input support
    bool previousChangeCharacterInput = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentCharacter = Instantiate<GameObject>(characterPrefab0, Vector3.zero, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        // change character on mouse press
        // if (Input.GetMouseButtonDown(0))
        if (Input.GetAxis("Change Character") > 0)
        {
            // change character input
            if (!previousChangeCharacterInput)
            {
                previousChangeCharacterInput = true;
            
                // save position and destroy current character
                Vector3 position = currentCharacter.transform.position;
                Destroy(currentCharacter);
            
                int prefabNumber = Random.Range(0, 4);
                switch (prefabNumber)
                {
                    case 0:
                        currentCharacter = Instantiate<GameObject>(characterPrefab0, position, Quaternion.identity);
                        break;
                    case 1:
                        currentCharacter = Instantiate<GameObject>(characterPrefab1, position, Quaternion.identity);
                        break;
                    case 2:
                        currentCharacter = Instantiate<GameObject>(characterPrefab2, position, Quaternion.identity);
                        break;
                    case 3:
                        currentCharacter = Instantiate<GameObject>(characterPrefab3, position, Quaternion.identity);
                        break;
                }
            } 
        }
        else
        {
            // no change character input
            previousChangeCharacterInput = false;   
        }
    }
}
