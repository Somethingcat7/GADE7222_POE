using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIRacerFactory : GenericFactory<AIRacer>
{
    private AIRacer[] generalAIs;

    private void Awake()
    {
        for (int i = 0; i < prefabs.Length; i++)
        {
            var car = GetNewInstance();
            car.transform.position = new Vector3(Random.Range(64, 80), 0, Random.Range(0, 5));
        }
    }
}
