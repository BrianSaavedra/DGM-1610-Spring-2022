using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float speed;
    public float jumpHeight;
    private bool isGrounded;
    private Rigidbody rb;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private float moveVelocity;



    // Start is called before the first frame update
    void Start()
    {
        isGrounded = true;
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpadte()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

        moveVelocity = 0f;

        if(Input.GetKey(KeyCode.D))
        {
            moveVelocity = speed;

        }
        if(Input.GetKey(KeyCode.A))
        {
            moveVelocity = -speed;

        }
        
        rb.velocity = new Vector3(moveVelocity,rb.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }


    public void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpHeight);
    }
}
