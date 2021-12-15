using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour
{
    [SerializeField] private Transform Obj1;
    [SerializeField] private Transform Obj2;
    [SerializeField] private GameObject bullet;
    [SerializeField] private float Speed;
    private GameObject _bulletGO;
    void Start()
    {
        _bulletGO = Instantiate(bullet, Obj1.position, Quaternion.identity);  
    }

    // Update is called once per frame
    void Update()
    {
        var direction = Obj2.position - Obj1.position;
        _bulletGO.transform.Translate(direction * Time.deltaTime* Speed);
    }
}
