using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turretmovement : MonoBehaviour
{
    
    void Start()
    {
        
    }

    public float turnSpeed = 75.0f;
    void Update()
    {
        float rotation = 0.0f;
        if (Input.GetKey(KeyCode.Q))
        {
            rotation = -turnSpeed * Time.deltaTime;

        }
        else if (Input.GetKey(KeyCode.E))

        {

            rotation = turnSpeed * Time.deltaTime;
        }




    }
}
