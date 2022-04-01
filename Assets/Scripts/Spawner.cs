using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnee;
    public bool stopSpawning = false;
    public float spawnTime = 2;
    public float spawnDelay = 1f;


    // Start is called before the first frame update
    void Start()
    {
        // Fire the provided method, after spawnTime seconds, every spawnDelay seconds

        int difficulty = PlayerPrefs.GetInt("Difficulty", 0) + 1;

        spawnDelay = spawnDelay / difficulty;

        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        var position = Random.Range(transform.position.x + 0.5f, transform.position.x + 9.5f);

        // Create a clone of the spawnee object, at a givent position and rotation
        Instantiate(spawnee, new Vector3(position, transform.position.y), transform.rotation);

        if(stopSpawning)
        {
            // Stop the spawning thread from running
            CancelInvoke("SpawnObject");
        }
    }



}
