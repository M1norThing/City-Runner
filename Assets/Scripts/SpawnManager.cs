using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private PlayerController playerControllerScript;
    [SerializeField] GameObject obstaclePrefab;
    [SerializeField] float spawnDelay = 2f;
    [SerializeField] float repeatRate = 2f;
    private Vector3 obstaclePosition = new Vector3(25, 0, 0);
    
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", spawnDelay, repeatRate);
    }

    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, obstaclePosition, obstaclePrefab.transform.rotation);
        }
    }
}
