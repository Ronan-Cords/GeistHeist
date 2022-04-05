using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerRigidBody;
    public bool isOnGround = true;

    public float jumpForce = 10;
    public float speed = 5;
    public float jumpCoolDown = 9;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && isOnGround == true)
        {
            StartCoroutine(JumpWait());
            
            
            
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

    public void OnCollisionEnter(Collision collision)
    {
        
        isOnGround = true;
    }

    IEnumerator JumpWait()
    {
        transform.Translate(Vector3.up * Time.deltaTime * jumpForce);
        yield return new WaitForSeconds(jumpCoolDown);

    }
}


       




  



