using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.EventSystems;

public class pauseGame : MonoBehaviour
{
    public bool isPaused = false;
    public GameObject myMenu;

    void Start()
    {
        myMenu.SetActive(false);
    }

    void Update()
    {
        //pause
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("1");
            isPaused = !isPaused;
            PauseGame();
        }
    }
    //activate pause menu here
    void PauseGame()
    {
        if (isPaused)
        {
            Time.timeScale = 0f;
            myMenu.SetActive(true);
            Debug.Log("2");

        }
        //this else was never being called, so the game was never being unpaused
        //thanks for that insight Ellie Garguilio
        else
        {
            Time.timeScale = 1;
            myMenu.SetActive(false);
        }
    }

    public void UnPause() {
        Debug.Log("3");
        Time.timeScale = 1;
        myMenu.SetActive(false);
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("Quit");
    }
}

