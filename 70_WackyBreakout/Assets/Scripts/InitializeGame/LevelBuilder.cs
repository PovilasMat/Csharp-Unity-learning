using UnityEngine;

public class LevelBuilder : MonoBehaviour
{
    [SerializeField] GameObject paddlePrefab;
    [SerializeField] GameObject blockstandardPrefab;
    [SerializeField] GameObject blockstrongPrefab;
    [SerializeField] GameObject blockshortPrefab;
    float standardBlockWidth;
    float standardBlockHeight;
    float screenWidth;
    float screenHeight;
    int blocksInRow;
    float edgeScreenLeft;

    void Awake()
    {
        Instantiate(paddlePrefab, new Vector3(0, -4.5f, 0), Quaternion.identity);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Instantiate the standard block prefab, check its width and height
        GameObject block = Instantiate(blockstandardPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        standardBlockHeight = block.GetComponent<Renderer>().bounds.size.y;
        standardBlockWidth = block.GetComponent<Renderer>().bounds.size.x;

        // Destroy the block
        Destroy(block);

        // Find the width and height of the screen using ScreenUtils
        screenWidth = ScreenUtils.ScreenRight - ScreenUtils.ScreenLeft;
        screenHeight = ScreenUtils.ScreenTop - ScreenUtils.ScreenBottom;

        // Calculate the number of blocks that can fit in a row
        blocksInRow = (int)(screenWidth / standardBlockWidth);
        edgeScreenLeft = (screenWidth - (blocksInRow * standardBlockWidth)) / 2;
        Debug.Log(edgeScreenLeft);
        // Calculate the starting position of the blocks (top left corner about a fifth of the screen from the top)
        Vector3 startingPosition = new Vector3(-screenWidth / 2 + standardBlockWidth / 2 + edgeScreenLeft, screenHeight / 2 * 4 / 5, 0);

        // Instantiate 3 rows of blocks
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < blocksInRow; j++)
            {
                // Instantiate a standard block prefab
                Instantiate(blockstandardPrefab, startingPosition + new Vector3(j * standardBlockWidth, -i * standardBlockHeight, 0), Quaternion.identity);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
