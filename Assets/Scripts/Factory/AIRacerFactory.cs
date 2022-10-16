using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIRacerFactory : GenericFactory<AIRacer>
{
    private AIRacer[] generalAIs;
    
    public float[] xpos;
    public float[] ypos; 

    private void Awake()
    {
        for (int i = 0; i < prefabs.Length; i++)
        {
            var car = GetNewInstance();
            car.transform.position = new Vector3(xpos[i], 0, ypos[i]);
        }
    }
}
