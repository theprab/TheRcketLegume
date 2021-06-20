using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class pauseGame : MonoBehaviour
{
    public static bool isPaused = false;
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
            isPaused = true;
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
            //SceneManager.LoadScene("Intermission", LoadSceneMode.Additive);

        }
        else
        {
            Debug.Log("3");
            Time.timeScale = 1;
            myMenu.SetActive(false);
            //SceneManager.UnloadScene("Intermission");
        }
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("Quit");
    }
}

