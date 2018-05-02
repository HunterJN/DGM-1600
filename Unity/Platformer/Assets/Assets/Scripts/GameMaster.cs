using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour {

    public static GameMaster gm;
    public static GameMaster instance = null;
    public static int collectedGems = CollectGems.newCollectedGems;
    [SerializeField]
    private int maxLives = 3;
    private static int _remainingLives;
    public static int RemainingLives
    {
        get { return _remainingLives; }
    }

    void Awake ()
    {

        _remainingLives = maxLives;

        if (gm == null)
        {
            gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        }

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

    public Transform playerPrefab;
    public Transform spawnPoint;
    public int spawnDelay = 2;
    public Transform spawnPrefab;
    public void EndGame()
    {
        Debug.Log("Game Over");
    }

    public IEnumerator RespawnPlayer ()
    {
        yield return new WaitForSeconds (spawnDelay);
        Instantiate(playerPrefab, spawnPoint.position, spawnPoint.rotation);
        Transform clone = Instantiate(spawnPrefab, spawnPoint.position, spawnPoint.rotation);
        Destroy(clone, 3f);
    }

	public static void KillPlayer (PlayerController player)
    {
        Destroy(player.gameObject);
        _remainingLives--;
        if (_remainingLives <= 0)
        {
            SceneManager.LoadScene(4);
        }
        else
        {
            gm.StartCoroutine(gm.RespawnPlayer());
        }

    }
    
    public static void KillEnemy (Enemy enemy)
    {
        Destroy(enemy.gameObject);
    }

    

    public void LoadLevel(string level)
    {
        collectedGems = 0;
        SceneManager.LoadScene(level);
    }

    public void LoadNextLevel()
    {
        collectedGems = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitApplication()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
