using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] GameObject creditsMenu;

    private void Start()
    {
        creditsMenu.SetActive(false);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void ShowCredits()
    {
        creditsMenu.SetActive(true);
        gameObject.SetActive(false);
    }
}
