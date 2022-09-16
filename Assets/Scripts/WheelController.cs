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

    //preset values for essential mechanics
    public float acceleration = 800f;
    public float breakingForce = 300f;
    public float TurningAngle = 45f;
    
    //placeholders
    private float currentAcceleration = 0f;
    private float currentBrakeForce = 0f;
    private float currentTurnAngle = 0f;

    

    private void FixedUpdate()
    {
        //get acceleration from axis
        currentAcceleration = acceleration * Input.GetAxis("Vertical");
                
        //sets braking force
        if (Input.GetKey(KeyCode.Space))
        {
            currentBrakeForce = breakingForce;
        }
        else
        {
            currentBrakeForce = 0f;
        }

        //gets horizontal input and sets left and right wheels to input
        currentTurnAngle = TurningAngle * Input.GetAxis("Horizontal");
        FrontLeft.steerAngle = currentTurnAngle;
        FrontRight.steerAngle = currentTurnAngle;
        
        //giving each wheel their respective force.
        FrontRight.motorTorque = currentAcceleration;
        FrontLeft.motorTorque = currentAcceleration;

        //all wheels have break force
        FrontRight.brakeTorque = currentBrakeForce;
        FrontLeft.brakeTorque = currentBrakeForce;
        BackLeft.brakeTorque = currentBrakeForce;
        BackRight.brakeTorque = currentBrakeForce;
    }
}
