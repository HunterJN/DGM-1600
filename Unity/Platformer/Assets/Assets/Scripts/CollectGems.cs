using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class CollectGems : MonoBehaviour {

    public static int newCollectedGems = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        newCollectedGems++;
        //Destroy(collision.gameObject);
        Destroy(gameObject);
        if (newCollectedGems >= 1)
        {
            FindObjectOfType<GameMaster>().LoadNextLevel();
        }
    }

    private Text gemsText;

        // Use this for initialization
        void Awake()
        {
            gemsText = GetComponent<Text>();
        }

        // Update is called once per frame
        void Update()
        {
            gemsText.text = "Gems: " + GameMaster.collectedGems;
        }
    }
