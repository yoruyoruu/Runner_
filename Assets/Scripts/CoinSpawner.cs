using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
   public GameObject coins;
   public List<Transform> spawnPoints;
   public float spawnDelay;
   float nextSpawn = 0.0f;

   void Update() 
    {
        if (Time.time > nextSpawn)
        {
        nextSpawn = Time.time + spawnDelay;    
        spawnPoints = new List<Transform>(spawnPoints);
        SpawnCoins();
        }
    }

    void SpawnCoins()
    {
        var spawn = Random.Range(0, spawnPoints.Count);
        Instantiate(coins,spawnPoints[spawn].transform.position,Quaternion.identity);
        
    }
}
