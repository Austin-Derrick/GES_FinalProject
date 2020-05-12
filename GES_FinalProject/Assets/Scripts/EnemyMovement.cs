using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody2D enemyRB;
    public float speed { get; private set; }

    private void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();
        speed = 5;
    }

    private void FixedUpdate()
    {
        float xVelocity = speed;
        Vector2 velocityVector = new Vector2(xVelocity, enemyRB.velocity.y);
        enemyRB.velocity = velocityVector;
    }

    public void flipSpeed()
    {
        speed *= -1;
    }

}
