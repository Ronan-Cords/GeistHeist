using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    
    public int MoveSpeed = 50;
    public int MinDist = 0;

    public GameObject PlayerStandIn;
    public Transform variableToUpdate;

    

    // Start is called before the first frame update
    void Start()
    {
        variableToUpdate = GameObject.Find("EnemyScriptTest").transform;
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Vector3.Distance(transform.position, variableToUpdate.position) >= MinDist)
        {
            transform.position += transform.right * MoveSpeed * Time.deltaTime;
            transform.position += transform.up * MoveSpeed * Time.deltaTime;
            transform.position -= transform.right * MoveSpeed * Time.deltaTime;
            transform.position -= transform.up * MoveSpeed * Time.deltaTime;
            Debug.Log("Working");
        }


         void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            {
                SceneManager.LoadScene(3);
            }
    }

}
}
