using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private RoadSpawner _roadSpawner;        // В плеере мы будем спавнить дороги, когда он пересекает тригеры
   
    private void OnTriggerEnter(Collider other) 
    {
        _roadSpawner.Spawn();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate (2.5f, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate (-2.5f, 0, 0);
        }
    }

}
