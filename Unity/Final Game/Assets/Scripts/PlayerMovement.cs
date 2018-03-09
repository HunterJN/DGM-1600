using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PolygonCollider2D))]

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rigid;
    public float speed;
    //private Animator anim;
    //private SpriteRenderer rend;

    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();
        //rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //check for button pushes

        rigid.AddForce(new Vector2(Input.GetAxis("Horizontal") * speed, 0), ForceMode2D.Force);
        rigid.AddForce(new Vector2(0, Input.GetAxis("Vertical") * speed), ForceMode2D.Force);
        /*anim.SetFloat("HorizontalMove", Input.GetAxisRaw("Horizontal"));
        if (Input.GetAxisRaw("Horizontal") < -0.1f)
        {
            //flip the sprite renderer
            rend.flipX = true;
        }
        else
        {
            //do not flip
            rend.flipX = false;
        }*/

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //hit.transform.GetComponent<Rigidbody2D>.AddForce(transform.right * speed);
    }
}
