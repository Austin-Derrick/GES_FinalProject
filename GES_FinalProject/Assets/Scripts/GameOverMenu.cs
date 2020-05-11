using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void restartGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void returnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void exitGame()
    {
        Application.Quit();
    }
}
