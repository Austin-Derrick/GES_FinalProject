using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreChickenCollider : MonoBehaviour
{
    [SerializeField] private GameObject chicken;
    void Start()
    {
        Physics2D.IgnoreCollision(chicken.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
    }
}
