using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopPlayerMovement : MonoBehaviour
{
    // Called when the object collides with a trigger Area
    public ShopPlayerStats stats;


    private void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * stats.speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * stats.speed * Time.deltaTime;
        }
    }
}
