using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerRigidBody;
  

    public float jumpForce = 10;
    public float speed = 5;
    private bool Jumped;
    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Jumped = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }

    private void OnCollisionStay()
    {
        isGrounded = true;
    }
    
        
    

    private void FixedUpdate()
    {
        if (Jumped && isGrounded)
        {
            playerRigidBody.AddForce(0, jumpForce, 0, ForceMode.Impulse);
            Jumped = false;
            isGrounded = false;
        }
    }




}


       




  



