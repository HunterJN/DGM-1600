using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePaddle : MonoBehaviour {

    public float moveSpeed = 5;
    private Rigidbody2D rigi;

    private void Awake()
    {
        rigi = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rigi.velocity = new Vector3(moveSpeed, 0, 0);        
    }

    private void OnCollsionEnter2D(Collision2D coll)
    {
        if (tag == "Right" || tag == "Left")
            rigi.velocity *= -1;
    }
}
