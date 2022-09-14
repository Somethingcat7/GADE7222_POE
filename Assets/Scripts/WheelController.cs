using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    [SerializeField] WheelCollider FrontRight;
    [SerializeField] WheelCollider FrontLeft;
    [SerializeField] WheelCollider Back;

    public float acceleration = 500f;
    public float breakingForce = 300f;
    public float currentAcceleration = 0f;
    public float currentBrakeForce = 0f;

    

    private void FixedUpdate()
    {
        //get acceleration from axis
        currentAcceleration = acceleration * Input.GetAxis("Vertical");
        
        if (Input.GetKey(KeyCode.Space))
        {
            currentBrakeForce = breakingForce;
        }
        else
        {
            currentBrakeForce = 0f;
        }

        FrontRight.motorTorque = currentAcceleration;
        FrontLeft.motorTorque = currentAcceleration;

        FrontRight.brakeTorque = currentBrakeForce;
        FrontLeft.brakeTorque = currentBrakeForce;
        Back.brakeTorque = currentBrakeForce;
    }
}
