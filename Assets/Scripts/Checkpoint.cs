using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private AllCheckPoints allCheckPoints;
    public Game_Manager game_Manager;
    private void OnTriggerEnter(Collider other)
    {
        //checks is the player is passing checkpoints
        if( other.gameObject.tag == "Player")
        {
            allCheckPoints.CheckpointPassed(this);
            game_Manager.Timer += 20;
            game_Manager.Checkpoints += 1;
        }
        
    } 
    //creates instance to be used in other class
    public void SetCheckPoints(AllCheckPoints allCheckPoints)
    {
        this.allCheckPoints = allCheckPoints;
    }
}
