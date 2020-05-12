using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartChickenMovement : MonoBehaviour
{
    ChickenMovement movementScript;
     [SerializeField] BoxCollider2D chickenCollider;
    private void Start()
    {
        movementScript = GetComponent<ChickenMovement>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            disableCollider();
        }
    }

    void disableCollider()
    {
        movementScript.enabled = true;
        chickenCollider.enabled = false;
        this.enabled = false;
    }

    public void startEnable()
    {
        Invoke("enableCollider", 1.0f);
    }

    private void enableCollider()
    {
        movementScript.enabled = false;
        chickenCollider.enabled = true;
        this.enabled = true;
    }
}
