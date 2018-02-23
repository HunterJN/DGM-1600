using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;
    public static int brickCount;
    public int a = 0;
    public int b = 0;
    public int c = 0;

    // Use this for initialization
    void Awake()
    {
        /*var height = 2 * Camera.main.orthographicSize;
        var width = height * Camera.main.aspect;
        print(height);
        print(width);*/

        //Singleton
        if (instance == null)
        {                                       //if instance is not assaigned
            instance = this;                    //the assign istance to this object
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);           //then destroy this object
        }

        DontDestroyOnLoad(this.gameObject);
    }

    public void LoadLevel(string level)
    {
        brickCount = 0;
        SceneManager.LoadScene(level);
    }

    public void LoadNextLevel()
    {
        brickCount = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadCurrentLevel()
    {
        /*a++;
        c = a + b;*/
        a = 0;
        a++;
        if (a == 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            a = a + 1;
            print("a:" + a);
            print("b:" + b);
            print("c: " + c);
        }
        else if (a == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
            a = a + 2;
            print("a: " + a);
            print("b: " + b);
            print("c: " + c);
        }
        else
        {
            SceneManager.LoadScene(0);
            print("a: " + a);
            print("b: " + b);
            print("c: " + c);
        }
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}
