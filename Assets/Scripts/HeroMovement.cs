using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour
{
    public float Speed;

    private Vector3 _direction;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _direction.x = Input.GetAxis("Horizontal");
        _direction.z = Input.GetAxis("Vertical");
        //Debug.Log(_direction);
    }

    void FixedUpdate()
    {
        transform.position = transform.position + _direction * Time.fixedDeltaTime * Speed;
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position = transform.position + _direction * Time.fixedDeltaTime * Speed * 2;
        }
    }
}
