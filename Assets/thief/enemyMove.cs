using UnityEngine;
using System.Collections;

public class enemyMove : MonoBehaviour 
{
    public float moveSpeed = 4f;
    public float wanderTime = 1.5f;
    public float waitTime = 2f;

    private Rigidbody2D rb;
    private Vector2 moveDirection;
    private SpriteRenderer spriteRenderer;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        if (rb != null) {
            rb.gravityScale = 0;
            rb.freezeRotation = true;
        }

        StartCoroutine(WanderRoutine());
    }

    IEnumerator WanderRoutine()
    {
        while (true)
        {
            // Pick direction
            moveDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
            
            // Start Walking
            if (animator != null) animator.SetFloat("Speed", 1f);
            if (moveDirection.x != 0) spriteRenderer.flipX = moveDirection.x < 0;

            Debug.Log("Thief is now wandering!"); // Check your Console for this!

            yield return new WaitForSeconds(wanderTime);

            // Stop Walking
            moveDirection = Vector2.zero;
            if (animator != null) animator.SetFloat("Speed", 0f);

            yield return new WaitForSeconds(waitTime);
        }
    }

    void FixedUpdate()
    {
        if (moveDirection != Vector2.zero)
        {
            rb.MovePosition(rb.position + moveDirection * moveSpeed * Time.fixedDeltaTime);
        }
    }
}