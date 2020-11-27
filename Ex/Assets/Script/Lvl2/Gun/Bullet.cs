using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : Score
{
    void OnTriggerEnter2D(Collider2D collision2D)
    {
        Destroy(gameObject);

        if (collision2D.GetComponent<EnemyGFX>())
        {
            Destroy(collision2D.gameObject);
            scor += 2;
        }
    }
        // Start is called before the first frame update
        void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

}
