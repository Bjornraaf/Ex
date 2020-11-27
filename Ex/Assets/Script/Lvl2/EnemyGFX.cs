using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyGFX : MonoBehaviour
{
    public float speed;

    private Transform target;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            transform.position = new Vector3(75, 13, 0);
        }
    }
        void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, target.position) > 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        

    }
}