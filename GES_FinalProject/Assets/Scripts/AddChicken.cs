using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddChicken : MonoBehaviour
{
    Inventory playerInventory;

    [SerializeField] BoxCollider2D playerCollider;
    private void Start()
    {
        playerInventory = GetComponent<Inventory>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Chicken"))
        {
            playerInventory.addChicken(collision.gameObject);
            playerCollider.enabled = false;
        }
    }
}
