using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    // bool gameHasEnded = false;
    public GameObject gameSound;
    public float restartDelay = 3f;
    public GameObject levelCompleteUI;
    public GameObject GameOverUI;
    public void LevelComplete()
    {   
        levelCompleteUI.SetActive(true);
    
    }
    public void GameOverDelay()
    {
        Invoke("GameOver",restartDelay);
    }
     public void GameOver()
    {   
        GameOverUI.SetActive(true);
        Sound();
    }
    public void NextGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    public void Quit()
    {
        Application.Quit();
        
    }
    public void Sound()
    {
        gameSound.SetActive(false);
    }
    // public void EndGame()
    // {
    //     if(gameHasEnded == false)
    //     {
    //         gameHasEnded = true;
    //         Debug.Log("GAMEOVER");
    //         Invoke("Restart",restartDelay);
    //     }

    // }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
