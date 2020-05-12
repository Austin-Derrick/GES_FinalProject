using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisionDetection : MonoBehaviour
{
    PlayerLivesManager playerLives;
    ScoreManager playerPoints;
    [SerializeField] public int health; //{ get; private set; }

    private void Start()
    {
        playerLives = GameObject.FindGameObjectWithTag("LivesManager").GetComponent<PlayerLivesManager>();
        playerPoints = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>();
        health = 1;
    }
    private void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chicken"))
        {
            Debug.Log("Collided with chicken");
            playerPoints.incrementScore();
            health--;
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collided with player");
            playerLives.decreaseHealth();
        }
    }

}
