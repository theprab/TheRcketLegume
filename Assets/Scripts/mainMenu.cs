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
    public void WinStory() {
        SceneManager.LoadScene("win-story-1");
    }
    public void WinStory2()
    {
        SceneManager.LoadScene("win-story-2");
    }
    public void LoseStory()
    {
        SceneManager.LoadScene("lose-story-1");
    }
    public void LoseStory2()
    {
        SceneManager.LoadScene("lose-story-2");
    }
}
