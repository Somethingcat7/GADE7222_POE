using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphNode : MonoBehaviour
{
    public int data;
    public LinkList<GraphNode> neighbours;

    public GraphNode(int inData)
    {
        data = inData;
        neighbours = new LinkList<GraphNode>();
    }

    public void AddNeighbour(GraphNode nb)
    {
        if (neighbours.SearchForNode(nb) != null)
        {
            return;
        }

        neighbours.AddTailNode(nb);

    }

   
    
    
    
}
