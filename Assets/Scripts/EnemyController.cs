using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float enemyCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyCount < 3)
        {

            Instantiate(EnemyPrefab, new Vector3(100, -75, -5), Quaternion.identity);
            enemyCount++;
        }
    }
}
