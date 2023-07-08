using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
   public GameObject Coin;
   public List<Transform> spawnPoints;
   public float spawnDelay;
   private float _nextSpawn = 0.0f;

   void Update() 
    {
        if (Time.time > _nextSpawn)
        {
        _nextSpawn = Time.time + spawnDelay;    
        SpawnCoins();
        }
    }

    void SpawnCoins()
    {
        var spawn = Random.Range(0, spawnPoints.Count);
        Instantiate(Coin,spawnPoints[spawn].transform.position,Quaternion.identity);
        
    }
}
