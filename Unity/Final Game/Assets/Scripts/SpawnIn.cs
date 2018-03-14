using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnIn : MonoBehaviour {

    public GameObject[] obj;
    public float spawnMin = 1f;
    public float spawnMax = 2f;
    public bool spawnOne = false;

	// Use this for initialization
	void Start () {
        Spawn();
	}
	
	// Update is called once per frame
	void Spawn()
    {
        //Instantiate(obj[Random.Range(0, obj.GetLength(0))], transform.position, Quaternion.identity);
        //Invoke("Spawn", Random.Range(spawnMin, spawnMax));
        if (spawnOne == false)
        {
            Instantiate(obj[0], transform.position, Quaternion.identity);
            Invoke("Spawn", Random.Range(spawnMin, spawnMax));
        }
    }
}
