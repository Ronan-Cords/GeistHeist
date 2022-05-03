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
    public GameObject EnemyDestroyFront;
    public GameObject EnemyDestroyBack;

    public float jumpForce = 10;
    public float speed = 5;
    private bool Jumped;
    public bool isGrounded;

    public SpriteRenderer playerRenderer;
    public Sprite PlayerAttackSprite;
    public Sprite PlayerAttackBehindSprite;
    public Sprite PlayerIdleSprite;
    public Sprite PlayerIdleBehindSprite;
    
    

    // Start is called before the first frame update
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
        playerRenderer = gameObject.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        // SPRITE NULL STATEMENT

        if (playerRenderer.sprite == null)
        {
            playerRenderer.sprite = PlayerIdleSprite;
        }
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
            playerRenderer.flipX = true;
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            playerRenderer.flipX = false;
        }
       

        if (transform.position.y < -53)
        {
            SceneManager.LoadScene(3);
        }

        //ENEMY DESTROY
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            EnemyDestroyFront.SetActive(true);
            playerRenderer.sprite = PlayerAttackSprite;
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            EnemyDestroyFront.SetActive(false);
            playerRenderer.sprite = null;

        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            EnemyDestroyBack.SetActive(true);
            playerRenderer.sprite = PlayerAttackBehindSprite;
        }

        if (Input.GetKeyUp(KeyCode.Q))
        {
            EnemyDestroyBack.SetActive(false);
            playerRenderer.sprite = null;
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


       




  



