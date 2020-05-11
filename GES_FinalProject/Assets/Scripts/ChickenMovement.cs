using System.Collections;
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
    private bool isFacingLeft = true;

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

    private void Update()
    {
        if (isFacingLeft && velocityVector.x > 0 || !isFacingLeft && velocityVector.x < 0)
        {
            flip();
        }
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

    private void flip()
    {
        isFacingLeft = !isFacingLeft;
        Vector3 scale = transform.localScale;
        scale.x = isFacingLeft ? 1 : -1;

        if (isFacingLeft) scale.x = 1;
        else scale.x = -1;

        transform.localScale = scale;
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
