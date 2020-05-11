using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddChicken : MonoBehaviour
{
    Inventory playerInventory;

    private void Start()
    {
        playerInventory = GetComponent<Inventory>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chicken"))
        {
            playerInventory.addChicken(collision.gameObject);
        }
    }
}
