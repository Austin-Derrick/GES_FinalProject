using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsMenu : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;

    public void returnToMainMenu()
    {
        gameObject.SetActive(false);
        mainMenu.SetActive(true);
    }
}
