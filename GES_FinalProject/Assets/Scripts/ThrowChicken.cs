using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowChicken : MonoBehaviour
{
    Inventory playerInventory;
    float throwForce = 20;

    private void Start()
    {
        playerInventory = GetComponent<Inventory>();
    }
    private void OnMouseDown()
    {
        GameObject chickenToThrow = playerInventory.getChicken();
        Rigidbody2D chickenRB = chickenToThrow.GetComponent<Rigidbody2D>();
        disableMovement(chickenToThrow);
        chickenRB.AddForce((new Vector2(1, 0.25f) * throwForce), ForceMode2D.Impulse);
    }

    private void disableMovement(GameObject chicken)
    {
        ChickenMovement movementScript = chicken.GetComponent<ChickenMovement>();
        movementScript.enabled = false;
    }
}
