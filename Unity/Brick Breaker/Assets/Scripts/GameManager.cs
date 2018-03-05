using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;
    public static int brickCount;

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

    /*public void LoadCurrentLevel()
    {
        if (brickCount > 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            print(SceneManager.GetActiveScene());
        }
    }*/

    public void QuitApplication()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
