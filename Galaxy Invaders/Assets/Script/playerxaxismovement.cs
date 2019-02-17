﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerxaxismovement : MonoBehaviour
{   private Transform player;

    // Start is called before the first frame update

    void Start()
    {
        // Player's position in 3D
        player = GetComponent<Transform> (); 
    }

    // Update is called once per frame
    void Update()
        {
        float speed = 0.3f;
        float maximum = 10.0f;
        float minimum = -10.0f;
        float direction = Input.GetAxis("Horizontal");
        // Do not allow the character to move beyond the boundary
        if ((direction < 0 && player.position.x < minimum) ||
        (direction > 0 && player.position.x > maximum)) 
            direction = 0; 
        //changing the position of the character 
        player.position += Vector3.right * direction * speed; 
        }
}
