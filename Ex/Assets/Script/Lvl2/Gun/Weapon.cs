using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Shoot
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public virtual void TriggerDown()
    {

    }
    public virtual void shoot()
    {

            Rigidbody2D instantiatedProjectile = Instantiate(Bullet, transform.position, transform.rotation) as Rigidbody2D;
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(speed, 0, 0));
       
    }
}
