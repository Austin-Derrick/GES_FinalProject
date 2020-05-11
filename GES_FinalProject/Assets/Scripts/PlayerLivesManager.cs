using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLivesManager : Singleton<MonoBehaviour>
{
    public int health { get; private set; }
    public int lives { get; private set; }
    private string sceneName;

    private void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;
        health = 3;
        lives = 1;
    }
    private void Update()
    {
        if (health <= 0)
        {
            resetHealth();
            SceneManager.LoadScene(sceneName);
            lives--;
        }
        if (lives < 0)
        {
            SceneManager.LoadScene("Lose Screen");
            lives = 0;
        }
    }

    public void decreaseHealth()
    {
        health--;
    }

    public void resetHealth()
    {
        health = 3;
    }
}
