using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queue<T>
{
    private readonly LinkList<T> linklist;

    public Queue()
    {
        linkedlist = new LinkList<T>();
    }

    public void AddToQueue(T data)
    {
        linkedlist.AddLast(data);
    }

    public T LookInQueue()
    {
        return linklist.Head.Data;
    }

    public T ClearQueue()
    {
        Node<T> node;
        linkedlist.Clear
        node = linkedlist.Head;

        return node.Data;
    }
   
}
