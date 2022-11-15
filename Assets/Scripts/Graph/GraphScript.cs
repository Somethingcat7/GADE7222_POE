using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class GraphScript
{
    private LinkedList<GraphNode> _nodes = new LinkedList<GraphNode>();

    public void NodeCreate(int value)
    {
        _nodes.AddToTail(new GraphNode(value));

    }

    public bool CreateEdge(int v1, int v2)
    {
        GraphNode g1 = FindNode(v1);
        GraphNode g2 = FindNode(v1);

        GraphNode temp = null;

        for (int i = 0; i < nodes.Size; i++)
        {
            temp = nodes.SearchForIndex(i);

            if (temp.Data == v1)
            {
                g1 = temp;
            }
        }
        for (int i = 0; i < nodes.Size; i++)
        {
            temp = nodes.SearchForIndex(i);

            if (temp.Data == v2)
            {
                g2 = temp;
            }
        }

        g1.AddNeighbour(g2);
    }
    
    
    


