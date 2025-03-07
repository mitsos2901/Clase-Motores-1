using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigidbody2D;
    private float horizontalMove = 0f;
    private Vector3 = currentVelocity;
    private float compensationSpeed = 10f;
    private bool facingRight = true; 
    private bool jumpPressed = false;
    private bool isGround = false; 
    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * runSpeed * compensationSpeed; 

        if(Input.GetKeyDown(KeyCode.Space)) {
            jumpPressed = true;
    }
    private void FixedUpdate()
    {
        Vector3 targetVelocity = new Vector2(horizontalMove * Time.fixedDeltaTime, rigidbody2D.velocity.y);
        rigidbody2D.velocity = Vector3.SmoothDamp(rigibody2D.velocity, targetVelocity, ref currentVelocity, movemntSmoothing);

        if (horizontalMove > 0f && !facingRight)
        {
        } else if (horizontalMove < 0f && facingRight)
        {
        }//flip to te right
    }
}
