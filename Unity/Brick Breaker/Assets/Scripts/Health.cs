using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    public int health;
    public Sprite newSprite;
    public Sprite newSprite2;

    //for using an array instead
    //public Sprites[] sprites;

    private void Awake()
    {
        GameManager.brickCount++;
        //print(GameManager.brickCount);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        health--;
        //GetComponent<SpriteRenderer>().sprite = sprites[health];
        //if our health gets to zero
        //then destroy this object

        if (health == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = newSprite;
        }
        else if (health == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = newSprite2;
        }
        else if (health <= 0)
        {
            Destroy(gameObject);
            GameManager.brickCount--;
            if(GameManager.brickCount == 0)
            {
                FindObjectOfType<GameManager>().LoadNextLevel();
            }
            //print(GameManager.brickCount);
        }
    }
}
