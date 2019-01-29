using System.Collections;
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

    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Function to move the player
        MainMovement();
        if (onGround)
        {
            MainJump();
        }
       

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

    private void MainJump()
    {
        //Moment the key is press
        if (Input.GetButtonDown("Jump"))
        {
            rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpPower);
        }
    }

}
