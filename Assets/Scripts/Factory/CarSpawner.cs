using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : GenericFactory<GeneralAI>
{
    private GeneralAI[] generalAIs;

    private void Awake()
    {
        /*var car = GetNewInstance();*/
        

        for (int i = 0; i < prefabs.Length; i++)
        {
            var car = GetNewInstance();
            car.transform.position = new Vector3(Random.Range(64, 80), 0, Random.Range(0, 5));
        }
    }
}
