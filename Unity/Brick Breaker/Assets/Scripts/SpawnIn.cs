using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnIn : MonoBehaviour {

    public Sprite newSprite;

    void Awake()
    {
        Invoke("DoSomething", 1);
        /*gameObject.GetComponent<SpriteRenderer>().sprite = newSprite;
        Vector3 spawnPosition = new Vector3(0, 0, 0);*/        
    }

    void DoSomething()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = newSprite;
        Vector3 spawnPosition = new Vector3(0, gameObject.transform.position.y, 0);
        gameObject.transform.position = spawnPosition;
        BoxCollider2D sc = gameObject.AddComponent(typeof(BoxCollider2D)) as BoxCollider2D;
    }
}
