using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void PlayGame() {
        SceneManager.LoadScene("rktlg");
    }
    public void StartMenu()
    {
        SceneManager.LoadScene("start");
    }
    public void QuitGame() {
        SceneManager.LoadScene("Quit");
    }
    public void LoseStory() {
        SceneManager.LoadScene("lose-story");
    }
    public void WinStory() {
        SceneManager.LoadScene("win-story-1");
    }
}
