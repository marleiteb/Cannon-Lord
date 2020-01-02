using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemys : MonoBehaviour
{
    public GameObject[] enemys;
    public GameObject[] spawnPoints;

    public float timeSpawn;

    void Start()
    {
        timeSpawn = 2;
        InvokeRepeating("SpawnEnemy", 0, timeSpawn);
    }

   
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        int localSpawn = Random.Range(0, spawnPoints.Length);

        if (GameController.gameC.points > 150 && GameController.gameC.points < 350)
        {
            timeSpawn -= 0.5f;
        }
        if (GameController.gameC.points >= 0 && GameController.gameC.points < 250)
        {

            Instantiate(enemys[0], spawnPoints[localSpawn].transform.position,
                spawnPoints[localSpawn].transform.rotation);
        }
        else if (GameController.gameC.points > 250)
        {
            int enemy = Random.Range(0, enemys.Length);
            Instantiate(enemys[enemy], spawnPoints[localSpawn].transform.position,
             spawnPoints[localSpawn].transform.rotation);
        }
    }

}
