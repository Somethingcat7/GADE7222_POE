using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class WaypointManager : MonoBehaviour
{
   public static WaypointManager instance;
    LinkList<GameObject> linkList;
    public GameObject[] ArrayOfCheckpoints;
     public GraphScript graph = new GraphScript();
    
     
     

    private void Awake()
    {
        instance = this;
        linkList = new LinkList<GameObject> ();
    }

    private void Start()
    {
        for (int i = 0; i < ArrayOfCheckpoints.Length; i++)
        {

            
            if (i == 0)
            {
                linkList.AddHeadNode(ArrayOfCheckpoints[i]);
            }
            else
            {
                linkList.AddTailNode(ArrayOfCheckpoints[i]);
            }
        }
    }

    public GameObject NextCheckpoint(GameObject gameObject)
    {
        return linkList.Next(gameObject);
    }

    public GameObject NextAICheckpoint(GameObject current)
    {
        LinkList<GraphNode> neighbours = graph.getNeighbours(Convert.ToInt32(current.name));

        int rnd = Random.Range(0, neighbours.Size);
        
        GraphNode next = neighbours.SearchForIndex(rnd);
        
        GameObject nextCheckPoint = null;

        for (int i = 0; i < ArrayOfCheckpoints.Length; i++)
        {
            if (Convert.ToInt32(ArrayOfCheckpoints[i].name) == next.data)
            {
                nextCheckPoint = ArrayOfCheckpoints[i];
            }
        }

        return nextCheckPoint;
        
    }
    
    
    
}
