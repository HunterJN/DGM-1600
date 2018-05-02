using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnIn : MonoBehaviour {

    public GameObject[] obj;
    public float spawnMin = 1f;
    public float spawnMax = 20f;
    //public bool spawnOne = false;
    //int i;

    // Use this for initialization
    void Start()
    {
        Spawn();
    }

    void Spawn()
    {
        Instantiate(obj[Random.Range(0, obj.GetLength(0))], transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(spawnMin, spawnMax));
        for (int i = 0; i < 1; i++)
        {
            Instantiate(obj[0], transform.position, Quaternion.identity);
            Invoke("Spawn", Random.Range(spawnMin, spawnMax));
        }
    }
}
