using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIManagerAdvanced : MonoBehaviour
{
    private void CreateNodeArray(int number)
    {
        for (int i = 1; i <= number; i++)
        {
            graph.CreateNode(i);
        }

        graph.CreateNode(-1);
    }

    private void CreateEdgeArray()
    {
        
    }    
    
}
