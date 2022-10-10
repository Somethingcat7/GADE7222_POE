using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericFactory<T> : MonoBehaviour where T : MonoBehaviour
{
    [SerializeField] private T instance;

    public T GetNewInstance()
    {
        return Instantiate(instance);
    }
}
