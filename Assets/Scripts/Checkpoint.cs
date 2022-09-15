using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private AllCheckPoints allCheckPoints;
    private void OnTriggerEnter(Collider other)
    {
        //checks is the player is passing checkpoints
        if( other.gameObject.tag == "Player")
        {
            allCheckPoints.CheckpointPassed(this);
        }
        
    } 
    //creates instance to be used in other class
    public void SetCheckPoints(AllCheckPoints allCheckPoints)
    {
        this.allCheckPoints = allCheckPoints;
    }
}
