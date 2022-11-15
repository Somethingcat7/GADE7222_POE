using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphNode : MonoBehaviour
{
    public int data;

    public GraphNode(int inData)
    {
        data = inData;
        neighbours = new LinkedList<GraphNode>();
    }

    public void AddNeighbour(GraphNode nb)
    {
        if (neighbours.SearchForNode(nb) != null)
        {
            return;
        }

        neighbours.AddToTail(nb);

    }

    public Node<X> SearchForNode(x search)
    {
        Node<X> returnNode = null;

        Node<X> currentNode = null;

        while (currentNode != null)
        {
            if (currentNode.Data.Equals(search))
            {
                returnNode = currentNode;
                break;
            }
            else
            {
                currentNode = currentNode.NextNode;
            }
        }

        return returnNode;
    }
    
    
    
}
