﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suck : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if (transform.position.x >= 62)
        {
            transform.position = transform.position + new Vector3(0, -0.03f, 0);

        }
    if (transform.position.x >= 89)
        {
            transform.position = transform.position + new Vector3(0, 0.03f, 0);

        }

        if (transform.position.x <= 89)
        {
            transform.position = transform.position + new Vector3(0, 0.00f, 0);
        }
    }
}
