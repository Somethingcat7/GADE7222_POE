using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIRacer : MonoBehaviour
{
    private NavMeshAgent navMesh;
    private GameObject Checkpoint;

    bool wait;

    private void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
        Checkpoint = GameObject.Find("CheckPoint1");
        navMesh.destination = Checkpoint.transform.position;

        wait = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Checkpoint") && !wait)
        {   
            StartCoroutine(Wait());
            Checkpoint = WaypointManager.instance.NextCheckpoint(Checkpoint);
            navMesh.destination = Checkpoint.transform.position;
        }
    }

    private IEnumerator Wait()
    {
        wait = true;

        yield return new WaitForSeconds(1f);

        wait = false;
    }
}
