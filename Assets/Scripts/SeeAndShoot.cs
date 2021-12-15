using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeAndShoot : MonoBehaviour
{
    [SerializeField] private Transform Obj1;
    [SerializeField] private Transform Obj2;
    [SerializeField] private GameObject bullet;
    [SerializeField] private float BulletSpeed;
    private GameObject _bulletFire;
    bool seePlayer;
    Transform target;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            seePlayer = true;
            target = other.transform;
            _bulletFire = Instantiate(bullet, Obj1.position, Quaternion.identity);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            transform.LookAt(other.transform);
            var direction = Obj2.position - Obj1.position;
            _bulletFire.transform.Translate(direction * Time.deltaTime * BulletSpeed);

        }
    }

    void Update()
    {
        if (seePlayer)
        {
            transform.LookAt(target);
        }
    }
}
