using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    [SerializeField] private Transform[] spawnPoints;                                                   // Points where cube(gameObject) will respawn
    [SerializeField] private GameObject cube;                                                           
    [SerializeField] private float spawnTime, spawnDelay;                                               //SpawnTime and spawnDelay beetween SpawnTime

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", spawnTime, spawnDelay);
    }

    void Spawn()
    {
        int randompoints = Random.Range(0, spawnPoints.Length);
        var enemy = Instantiate(cube, spawnPoints[randompoints].transform.position, Quaternion.Euler(0, 0, 0));
    }
}
