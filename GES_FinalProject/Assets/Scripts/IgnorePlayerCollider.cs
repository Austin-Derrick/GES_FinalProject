﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnorePlayerCollider : MonoBehaviour
{
    [SerializeField] private GameObject player;
    void Start()
    {
        Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
    }
}
