using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Transform[] spawnLocations;
    public GameObject[] whatToSpawnPrefab;
    public GameObject[] whatToSpawnClone;

    void Start () {

        SpawnPlayer();
    }

    public void SpawnPlayer() {

        whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLocations[0].transform.position, Quaternion.Euler(0,0,0)) as GameObject;
    }

    public void SpawnNewPlayer1()
    {

        whatToSpawnClone[1] = Instantiate(whatToSpawnPrefab[1], spawnLocations[1].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            Debug.Log(collision.gameObject.tag);
            Destroy(collision.gameObject);

            // An IF Statement should go in here to determine which Player was just destroyed, and call the function that spawns a different one.
            SpawnNewPlayer1();
        }
    }
}
