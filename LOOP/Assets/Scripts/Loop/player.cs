using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float gravity;
    public Vector2 velocity;
    public float jumpVelocity = 20;
    public float groundHeight = 10;
    public bool isGrounded = false;
    void Start()
    {
        
    }
    
    void Update()
    {
        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                isGrounded = false;
                velocity.y = jumpVelocity;
            }
        }
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;
        //Time.fixedDeltaTime; //locked framerate, want our jumps to always look the same.
        if (!isGrounded)
        {
            pos.y += velocity.y * Time.fixedDeltaTime;
            velocity.y += gravity * Time.fixedDeltaTime;

            if (pos.y <= groundHeight)
            {
                isGrounded = true;
            }
        }

        transform.position = pos;
    }

}
