using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class pauseGame : MonoBehaviour
{
    public static bool isPaused = false;

    void Update()
    {
        //pause
        if (Input.GetKeyDown(KeyCode.Escape))
        {
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
            SceneManager.LoadScene("Intermission", LoadSceneMode.Additive);

        }
        else
        {
            Time.timeScale = 1;
            SceneManager.UnloadSceneAsync("Intermission");
        }
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("Quit");
    }
}

