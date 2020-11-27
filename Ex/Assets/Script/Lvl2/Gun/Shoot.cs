using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Rigidbody2D Bullet;
    public float speed = 30;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody2D instantiatedProjectile = Instantiate(Bullet,transform.position,transform.rotation) as Rigidbody2D;
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0,speed, 0));

        }
    }
}
