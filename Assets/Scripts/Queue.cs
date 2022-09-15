using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queue<T>
{
    private readonly LinkList<T> linklist;

    public Queue()
    {
        linklist = new LinkList<T>();
    }

    public void AddToQueue(T data)
    {
        linklist.AddTailNode(data);
    }

    public T LookInQueue()
    {
        return linklist.Head.Data;
    }

    public T Dequeue()
    {
        Node<T> node;
        linklist.DeleteAtHead();
        node = linklist.Head;
        return node.Data;
    }
   
}
