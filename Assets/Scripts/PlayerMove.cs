using UnityEngine;

public class SimplePlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float moveX = 0;
        float moveY = 0;

        if (Input.GetKey(KeyCode.W))
        {
            moveY = moveSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveY = -moveSpeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            moveX = -moveSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveX = moveSpeed;
        }

        rb.velocity = new Vector2(moveX, moveY);
        animator.SetFloat("Speed", Mathf.Abs(moveX) + Mathf.Abs(moveY));
    }
}
