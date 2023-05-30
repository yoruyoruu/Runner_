using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    [SerializeField] private List <GameObject> _roads;      // создаем лист, куда прикрепим дорожки
    [SerializeField] private float _roadLengh;
    private GameObject _road;

    void Start()
    {
        _road = Instantiate (_roads[Random.Range(0, _roads.Count - 1)], transform.position, Quaternion.identity);     // спавним первую дорогу
        
    }

    public void Spawn()
    {
        Vector3 position = new Vector3(0, 0, _road.transform.position.z + _roadLengh);
         _road = Instantiate (_roads[Random.Range(0, _roads.Count - 1)], position, Quaternion.identity);   // спавним последующие
    }

}
