using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerRigidBody;
    public GameObject ArtifactManagementObject;
    public Transform Enemy;
    public Transform Player;

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
        // BASIC MOVEMENT
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

        if (transform.position.y < -53)
        {
            SceneManager.LoadScene(3);
        }

        //ENEMY DESTROY
        
        if (Input.GetKey(KeyCode.E))
        {
            if (Enemy.position.x <= Player.position.x + 6)
            {
                if (Enemy.position.y <= Player.position.y + 6 || Enemy.position.y >= Player.position.y -6)
                {
                    Debug.Log("Would Destroy");
                }
                
            }
            else
            {
                Debug.Log("Get Closer");
            }
        }

        if (Input.GetKey(KeyCode.Q))
        {
            // Use prefab position to destroy if within 3 units X behind
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

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Artifact"))
        {
            Destroy(other.gameObject);
            Debug.Log("Artifact Counted");
            ArtifactManagementObject.GetComponent<ArtifactManagement>().ArtifactCounter();
            
        }
    }

 




}


       




  



