using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    [SerializeField] WheelCollider FrontRight;
    [SerializeField] WheelCollider FrontLeft;
    [SerializeField] WheelCollider BackLeft;
    [SerializeField] WheelCollider BackRight;

    public float acceleration = 500f;
    public float breakingForce = 300f;
    public float maxTurnAngle = 30f;
    
    
    private float currentAcceleration = 0f;
    private float currentBrakeForce = 0f;
    private float currentTurnAngle = 0f;

    

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
        BackLeft.brakeTorque = currentBrakeForce;
        BackRight.brakeTorque = currentBrakeForce;

        currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal");
        FrontLeft.steerAngle = currentTurnAngle;
        FrontRight.steerAngle = currentTurnAngle;
    }
}
