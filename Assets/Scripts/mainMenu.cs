using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void PlayGame() {
        SceneManager.LoadScene("rktlg");
    }
    public void QuitGame() {
        SceneManager.LoadScene("Quit");
    }
}
