﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float characterSpeed = 5.0f;
    [SerializeField] float jumpPower = 5.0f;
    [SerializeField] float localScale = 5.0f;

    private Animator myAnimator;
    public bool onGround = true;
    public Rigidbody2D rigidbody;
    private Collider2D collider2D;
    public Vector2 respawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody.GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        collider2D = GetComponent<Collider2D>();
        respawnPosition = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Function to move the player
        MainMovement();

        //Check if the player is on the ground
        if (!collider2D.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {
            //If not on ground does nothing
            return;
        }
            MainJump();
        

       

    }

    public void MainMovement()
    {
        //Check if the player move right
        if (Input.GetAxisRaw("Horizontal") > 0f)
        {
            //Move right
            rigidbody.velocity = new Vector2(characterSpeed, rigidbody.velocity.y);
            //Rotate the char depending of the side
            transform.localScale = new Vector2(localScale, localScale);
        }
        else if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            //Move left
            rigidbody.velocity = new Vector2(-characterSpeed, rigidbody.velocity.y);
            //Rotate the char depending of the side
            transform.localScale = new Vector2(-localScale, localScale);
        }
        else
        // If no movement
        {
            rigidbody.velocity = new Vector2(0, rigidbody.velocity.y);
        }
        //Value of the animator
        myAnimator.SetFloat("Speed", Mathf.Abs(rigidbody.velocity.x));
        myAnimator.SetBool("onGround", onGround);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "deathzone")
        {
            transform.position = respawnPosition;
        }
    }

    private void MainJump()
    {
        //Moment the key is press
        if (Input.GetButtonDown("Jump"))
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpPower);
        }
    }

}
