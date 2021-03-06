﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowChicken : MonoBehaviour
{
    Inventory playerInventory;
    [SerializeField] Collider2D playerCollider;
    [SerializeField] StartChickenMovement chickenMovementScript;
    float throwForce = 20;

    private void Start()
    {
        playerInventory = GetComponent<Inventory>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject chickenToThrow = playerInventory.getChicken();
            Rigidbody2D chickenRB = chickenToThrow.GetComponent<Rigidbody2D>();
            disableMovement(chickenToThrow);
            chickenRB.AddForce((new Vector2(1, 0.25f) * throwForce), ForceMode2D.Impulse);
            chickenMovementScript.startEnable();
            Invoke("enableCollider", 1.0f);
        }
    }
    private void disableMovement(GameObject chicken)
    {
        ChickenMovement movementScript = chicken.GetComponent<ChickenMovement>();
        movementScript.enabled = false;
    }

    private void enableCollider()
    {
        playerCollider.enabled = true;
    }
}
