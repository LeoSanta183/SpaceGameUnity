using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] asteroidPrefabs;
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("SpawnAsteroid", 0.5f, 1f); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnAsteroid()
    {
        int randomSpawn;
        randomSpawn = Random.Range(0, 4);
        Instantiate(asteroidPrefabs[randomSpawn], new Vector3(Random.Range(-10, 10), 7.5f, 0), Quaternion.Euler(0, 0, 180));
    }
}
