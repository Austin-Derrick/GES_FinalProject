using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;

[DisallowMultipleComponent]

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]

public class PlayerController : MonoBehaviour
{
    [Header("Ground Movement")]
    [Tooltip("Movement speed in tiles per second (1 tile = 1 meter)")]
    [SerializeField]
    private float speed;

    [Header("Air Movement")]
    [Tooltip("The upward force applied when player jumps.")]
    [SerializeField]
    [Range(0, 10)]
    private float jumpForce;

    private Rigidbody2D playerRB;
    private bool isFacingRight = true;
    private bool isOnGround = true;
    private float distanceToCheck = 0.05f;
    new private Collider2D collider;
    private RaycastHit2D[] hits = new RaycastHit2D[16];
    private Animator animator;
    float horizontalInput = 0;
    bool isJumpPressed = false;
    public float xVelocity { get; private set; }
    public Vector2 velocityVector { get; private set; }
    public Vector2 jumpVector { get; private set; }
    public bool isJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        collider = GetComponent<Collider2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput += Input.GetAxis("Horizontal");
        isJumpPressed = isJumpPressed || Input.GetButton("Jump");
    }

    private void FixedUpdate()
    {
        xVelocity = horizontalInput * speed;
        velocityVector = new Vector2(xVelocity, playerRB.velocity.y);
        playerRB.velocity = velocityVector;

        if (isFacingRight && horizontalInput < 0 || !isFacingRight && horizontalInput > 0)
        {
            flip();
        }

        int numHits = collider.Cast(Vector2.down, hits, distanceToCheck);
        isOnGround = numHits > 0;

        Vector2 rayStart = new Vector2(collider.bounds.center.x, collider.bounds.min.y);
        Vector2 rayDir = Vector2.down * distanceToCheck;

        Debug.DrawRay(rayStart, rayDir, Color.red, 1f);

        if (isJumpPressed && isOnGround)
        {
            isJumping = true;
            jumpVector = Vector2.up * jumpForce;
            playerRB.AddForce(jumpVector, ForceMode2D.Impulse);
        }
        // updates animator system after updating player movement
        animator.SetBool("isOnGround", isOnGround);
        animator.SetFloat("xSpeed", Mathf.Abs(playerRB.velocity.x));
        animator.SetFloat("yVelocity", playerRB.velocity.y);

        clearInputs();
    }

    private void flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 scale = transform.localScale;
        scale.x = isFacingRight ? 1 : -1;

        if (isFacingRight) scale.x = 1;
        else scale.x = -1;

        transform.localScale = scale;
    }

    private void clearInputs()
    {
        horizontalInput = 0;
        isJumpPressed = false;
        isJumping = false;
    }
    
}
