using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public int Number;
    public Transform Position;
    public GameObject EnemyPrefab;

    void Start()
    {
        var g01 = Instantiate(EnemyPrefab, Position.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
