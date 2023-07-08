using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float turnSpeed = 90f;
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _coinMesh;

    private void Update()
    {
        _coinMesh.transform.Rotate(0 , 0 , turnSpeed * Time.deltaTime);
        DestroyCoin();
    } 

    private void FixedUpdate() 
    {
        Move();
    }

    private void Move()
    {
        transform.Translate (-transform.forward * _speed * Time.fixedDeltaTime);
    }

      private void DestroyCoin()
    {
        if (transform.position.z < -23f)
        {
            Destroy(gameObject);
        }
    }
    
}
