using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PolygonCollider2D))]

public class EnemyMovement : MonoBehaviour {

    private Rigidbody2D rigid;
    public float speed;
    public Transform Player;

    // Use this for initialization
    void Start () {
        rigid = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        //rigid.AddForce(new Vector2(Input.GetAxis("Horizontal") * speed, 0), ForceMode2D.Force);
        //rigid.AddForce(new Vector2(0, Input.GetAxis("Vertical") * speed), ForceMode2D.Force);
        if (Player == true)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Player.position, step);
        }
        /*else if (Player == false)
        {
            SceneManager.LoadScene("Game Over");
        }*/
    }
}