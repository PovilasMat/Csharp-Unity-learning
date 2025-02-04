using NUnit.Framework;
using UnityEditor;
using UnityEngine;

/// <summary>
/// script that will spawn asteroid, at least 4 of them
/// </summary>
public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] GameObject prefabAsteroid;
    Direction[] directions = { Direction.Left, Direction.Right, Direction.Up, Direction.Down };
    
    float asteroidRadius;
    Vector3 spawnLocation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float[] spawnSides = { ScreenUtils.ScreenRight, ScreenUtils.ScreenLeft, ScreenUtils.ScreenBottom, ScreenUtils.ScreenTop };

        GameObject gameObject = Instantiate<GameObject>(prefabAsteroid, transform.position, Quaternion.identity);
        asteroidRadius = gameObject.GetComponent<CircleCollider2D>().radius;
        Destroy(gameObject);
        float xOffset = Random.Range(-1, 1);
        float yOffset = Random.Range(-1, 1);
        for (int i = 0; i < 4; i++)
        {
            // spawn 2 asteroids
            if (i == 0)
            {
                spawnLocation = new Vector3(spawnSides[i] + asteroidRadius/2, yOffset, 0);
            }
            if (i == 1)
            {
                spawnLocation = new Vector3(spawnSides[i] + asteroidRadius/2, -yOffset, 0);
            }
            if (i == 2)
            {
                spawnLocation = new Vector3(xOffset, spawnSides[i] - asteroidRadius/2, 0);
            }
            if (i == 3)
            {
                spawnLocation = new Vector3(-xOffset, spawnSides[i] - asteroidRadius/2, 0);
            }

            GameObject asteroid = Instantiate(prefabAsteroid, transform.position, Quaternion.identity);

            // initialize asteroid
            Asteroid asteroidScript = asteroid.GetComponent<Asteroid>();
            asteroidScript.Initialize(directions[i], spawnLocation);
        }


        //foreach (Direction direction in directions)
        //{
            // instantiate asteroid
        //    GameObject asteroid = Instantiate(prefabAsteroid, transform.position, Quaternion.identity);
            // initialize asteroid
        //    Asteroid asteroidScript = asteroid.GetComponent<Asteroid>();
        //    asteroidScript.Initialize(direction, spawnLocation);
        //}
    }
}
