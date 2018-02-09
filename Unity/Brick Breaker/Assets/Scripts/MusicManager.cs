using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

    public static MusicManager instance = null;

	// Use this for initialization
	void Awake ()
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
	
}
