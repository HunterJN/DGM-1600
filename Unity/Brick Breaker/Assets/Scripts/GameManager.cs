using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;

    // Use this for initialization
    void Awake()
    {
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
        SceneManager.LoadScene(level);
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}
