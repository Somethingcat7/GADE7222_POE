using UnityEngine;
using System.Collections;
using System.Collections.Generic;



public class GraphScript
{
    private LinkList<GraphNode> _nodes = new LinkList<GraphNode>();

    public void NodeCreate(int value)
    {
        _nodes.AddTailNode(new GraphNode(value));

    }

    public void CreateEdge(int v1, int v2)
    {
        GraphNode g1 = null;
        GraphNode g2 = null;

        GraphNode temp;

        for (int i = 0; i < _nodes.Size; i++)
        {
            temp = _nodes.SearchForIndex(i);

            if (temp.data == v1)
            {
                g1 = temp;
            }
        }

        for (int i = 0; i < _nodes.Size; i++)
        {
            temp = _nodes.SearchForIndex(i);

            if (temp.data == v2)
            {
                g2 = temp;
            }
        }
        g1.AddNeighbour(g2);
    }

    public LinkList<GraphNode> getNeighbours(int vertex)
    {
        GraphNode node = null;
        GraphNode temp;

        for (int i = 0; i < _nodes.Size; i++)
        {
            temp = _nodes.SearchForIndex(i);

            if (temp.data == vertex)
            {
                node = temp;
            }
            
        }

        return node.neighbours;
    }
    

}
    
    
    


