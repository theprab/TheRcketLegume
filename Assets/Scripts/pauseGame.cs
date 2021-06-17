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
            SceneManager.LoadScene("Intermission", LoadSceneMode.Additive);
            Time.timeScale = 0f;
        }
        else
        {
            SceneManager.UnloadSceneAsync("Intermission");
            Time.timeScale = 1;
        }
    }
    public void ResumeGame() {
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        SceneManager.LoadScene("Quit");
    }
}

