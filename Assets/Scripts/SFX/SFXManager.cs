using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
   public static SFXManager Instance { get; private set; }

    private string[] SFXKey;
    private readonly int tablesize;

    public SFXManager(int maxtablesize)
    {
        tablesize = maxtablesize;
        SFXKey = new string[tablesize];
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
