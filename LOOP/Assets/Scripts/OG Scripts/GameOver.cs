using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GameOver : MonoBehaviour
{
    /*public static event Action<string> OnGameOver;

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health < 0)
        {
            OnGameOver?.Invoke("Nice try, Play again?");
        }
    }*/
    
    public int sceneToLoad;
    public void EndGame()
    {
        SceneManager.LoadScene(sceneToLoad); // Scene to load
    }
    public void QuitGame() //continue game after dying
    {
        Application.Quit(); //quit scene
        Debug.Log("Continue?"); // start again to game again
    }
}
