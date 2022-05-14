using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    bool gameHasEnded;
    public float restartDelay = 2f;
    public GameObject completeLevelUI;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        gameHasEnded = false;
    }

    public void GameEnd()
    {
        if (gameHasEnded == false)
        {
            Debug.Log("GAME OVER!");
            CompleteLevel();
            
            // Setting True so that their is only one GameOver not multiple at a time.
            gameHasEnded = true;

            //Invoke("Restart", restartDelay);
        }
    }

    //public void GameStart()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().+ 1);
    //}

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ReturnToMenu()
    {
        Debug.Log("Return to Main Menu.");
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
