using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GenericFactory<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField] protected T[] prefabs;
    private int prefabindex;

    public T GetNewInstance()
    {
        var inst = Instantiate(prefabs[prefabindex]);
        prefabindex++;
        return inst;
    }
}
