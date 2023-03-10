using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
    //THIS CODE MAKES THE ANIMALS SPAWN ON THE SCENE 
{
    public GameObject[] animalPrefabs;
    //where animals will spawn at (using X and Z)
    private float spawnRangeX = 17;
    private float spawnPosZ = 20;

    // Start is called before the first frame update
    void Start()
    {
        //takes a method, starts to call that method and will repeat calling it over time 
        InvokeRepeating("SpawnRandomAnimal", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //creates our own function which automatically generates new spawn of animals
    void SpawnRandomAnimal()
    {
        //use the Random() function that generates different and random numbers which is the index of different animals and random position
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        //where does the animals will spawn 
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
    
}
