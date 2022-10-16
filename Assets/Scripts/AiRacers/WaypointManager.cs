using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointManager : MonoBehaviour
{
   public static WaypointManager instance;
    LinkList<GameObject> linkList;
    public GameObject[] ArrayOfCheckpoints;


    private void Awake()
    {
        instance = this;
        linkList = new LinkList<GameObject> ();
    }

    private void Start()
    {
        for (int i = 0; i < ArrayOfCheckpoints.Length; i++)
        {

            /*Debug.Log(ArrayOfCheckpoints[i].name);*/
            if (i == 0)
            {
                linkList.AddHeadNode(ArrayOfCheckpoints[i]);
            }
            else
            {
                linkList.AddTailNode(ArrayOfCheckpoints[i]);
            }
        }
    }

    public GameObject NextCheckpoint(GameObject gameObject)
    {
        return linkList.Next(gameObject);
    }
}
