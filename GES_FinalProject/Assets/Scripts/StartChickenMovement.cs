using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartChickenMovement : MonoBehaviour
{
    ChickenMovement movementScript;
    private void Start()
    {
        movementScript = GetComponent<ChickenMovement>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            movementScript.enabled = true;
        }
    }
}
