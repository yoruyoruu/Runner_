using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private RoadSpawner _roadSpawner;        // В плеере мы будем спавнить дороги, когда он пересекает тригеры
    [SerializeField] private float _rightDistantion;
    [SerializeField] private float _leftDistantion;
   
    private void OnTriggerEnter(Collider other) 
    {
        _roadSpawner.Spawn();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate (_rightDistantion, 0, 0);
        }

        if (transform.position.x > 3)
        {
            transform.position = new Vector3 (2.5f,1,0);
        }

        if (transform.position.x < -3)
        {
            transform.position = new Vector3 (-2.5f,1,0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate (_leftDistantion, 0, 0);
        }
    }

}
