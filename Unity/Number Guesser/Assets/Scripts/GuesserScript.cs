using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuesserScript : MonoBehaviour {

    public int max;
    public int min;
    public int guess;

    // Use this for initialization
    private void Start () {

        max = Random.Range(10, 1000);
        print("Welcome to Number Guesser!");
        print("Pick a number between " + min + " and " + max);

        //Is the value GUESS
        NextGuess();
        //Instructions - Push these buttons
        print("Up Arrow = Higher, Down Arrow = Lower, Enter = Correct");
        max++;
    }

    void NextGuess()
    {
        guess = Random.Range(min, max);
        print("Is the number " + guess + "?");
        if (min >= max)
        {
            print("Computer Wins");
            Application.Quit();
        }
    }
	
	// Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up Arrow Pressed");
            min = guess+1;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down Arrow Pressed");
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("Return Button Pressed");
            print("Computer Wins");
            Application.Quit();
        }
        else if (Input.anyKeyDown)
        {
            print("Incorrect Input");            
        }        
	}
}
