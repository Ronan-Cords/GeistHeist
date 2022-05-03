using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float enemyCount = 0;
    public Transform playerTransform;
    public Transform enemyTransform;
    public SpriteRenderer enemyrenderer;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        enemyTransform = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        EnemyCount();
    }

    public void EnemyDestroyDetect()
    {
        enemyCount--;
    }

    void EnemyCount()
    {
        if (enemyCount < 3)
        {
            Instantiate(EnemyPrefab, new Vector3(100, -75, 0), Quaternion.identity);
            enemyCount++;
            
        }
    }

    public void EnemyFlip()
    {
        if (playerTransform.position.x < enemyTransform.position.x)
        {
            enemyrenderer.flipX = true;
        }

        else
        {
            enemyrenderer.flipX = false;
        }
                
    }

}
