﻿using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ChickenMovement : MonoBehaviour
{
    [SerializeField] PlayerController player;
    private Rigidbody2D chickenRB;
    private float deadZone;
    private Vector2 velocityVector;
    private Vector2 jumpVector;
    private float delay = 0.35f;
    float timer = 0;
    bool isMoving = false;
    private List<Vector2> playerVelocities;
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        chickenRB = GetComponent<Rigidbody2D>();
        deadZone = 0.15f;
        velocityVector = player.velocityVector;
        jumpVector = player.jumpVector;
        playerVelocities = new List<Vector2>();
        count = 0;
    }

    private void FixedUpdate()
    {
        timer += Time.deltaTime;
        velocityVector = player.velocityVector;
        playerVelocities.Add(velocityVector);
        jumpVector = player.jumpVector;
        if (timer > delay)
        {
            moveChicken();
            count++;
        }
    }
    // Update is called once per frame

    private void moveChicken()
    {
        chickenRB.velocity = playerVelocities[count];
        if (player.isJumping)
        {
            chickenRB.AddForce(jumpVector);
        }
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        isMoving = false;
    //    }
    //}
    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        isMoving = false;
    //    }
    //}

}