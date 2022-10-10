using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] private float iNum = 30;
    private int iCount = 0;

    [SerializeField] TimedObjectFactory factory;

    public void Update()
    {
        var iCount2 = Time.time * (iNum / 60);

        while (iCount2 > iCount)
        {
            var inst = factory.GetNewInstance();
            inst.transform.position = new Vector3(0, 0, 0);
        }

        iCount++;
    }
}
