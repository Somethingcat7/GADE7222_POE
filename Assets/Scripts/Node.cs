using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node<T>
{
    private T data;
    public T Data { get { return data; } set { data = value; } }

    private Node<T> next;

    public Node(T data)
    {
        this.data = data;
    }

    public Node<T> Next { get { return next; } set { next = value; } }

    public void setNext(Node<T> next)
    {
        this.next = next;
    }

    public Node<T> getNext()
    {
        return this.Next;
    }

}
