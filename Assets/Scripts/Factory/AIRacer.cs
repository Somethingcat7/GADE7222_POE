using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIRacer : MonoBehaviour
{
    private NavMeshAgent navMesh;
    public GameObject Checkpoint;

    private void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
        navMesh.destination = Checkpoint.transform.position;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Checkpoint"))
        {
            //Checkpoint = WaypointManager.instance.NextCheckpoint(Checkpoint);
            //navMesh.destination = Checkpoint.transform.position;
            
            Checkpoint = WaypointManager.instance.NextAICheckpoint(Checkpoint);
            navMesh.destination = Checkpoint.transform.position;
        }
    }

    
}
