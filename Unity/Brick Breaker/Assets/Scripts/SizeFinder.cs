using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeFinder : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var height = 2 * Camera.main.orthographicSize;
        var width = height * Camera.main.aspect;

        print(height);
        print(width);

    }
}
