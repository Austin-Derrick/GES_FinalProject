using System.Collections;
using System.Collections.Generic;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLivesDisplay : MonoBehaviour
{
    [SerializeField] private Text livesText;
    private PlayerLivesManager livesManager;

    private void Start()
    {
        GameObject livesManagerObject = GameObject.Find("LivesManager");
        livesManager = livesManagerObject.GetComponent<PlayerLivesManager>();
    }

    void Update()
    {
        livesText.text = $"Lives: {livesManager.lives}";
    }
}
