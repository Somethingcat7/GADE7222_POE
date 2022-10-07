using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllCheckPoints : MonoBehaviour
{
    
    private List<Checkpoint> CheckpointsList;
    //index keeping track of checkpoints
    private int Index;
    private void Awake()
    {
        //finds all checkpoints in heirarchy
        Transform checkpointsTransform = transform.Find("Checkpoints");

        CheckpointsList = new List<Checkpoint>();
        foreach (Transform singleCheckpoint in checkpointsTransform)
        {
            Checkpoint checkpoint = singleCheckpoint.GetComponent<Checkpoint>();
            //calls value from separate class
            checkpoint.SetCheckPoints(this);
            CheckpointsList.Add(checkpoint);
        }

        //sets index to 0 to start
        Index = 0;

    }

    
    public void CheckpointPassed(Checkpoint checkpoint)
    {
        //compares checkpoint number with correct index value
        if (CheckpointsList.IndexOf(checkpoint) == Index)
        {
            Debug.Log("KEEP GOING!");
            Index++;
        }
        else
        {
           Debug.Log("WRONG WAY!"); 
        }
        
        
    }
    
}
