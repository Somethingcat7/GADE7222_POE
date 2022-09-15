using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkList<T>
{
    public Node<T> head;
    public Node<T> tail;
    private int size = 0;

    public Node<T> Head { get { return head; } set { head = value; } }
    public Node<T> Tail { get { return tail; } set { tail = value; } }
    public int Size { get { return size; } set { size = value; } }

    public LinkList()
    {

    }

    public LinkList(Node<T> head)
    {
        this.head = head;
    }

    /*public int Size()
    {
        return 0;
    }*/

    public Node<T> GetFirstNode()
    {
        return this.head;
    }

    public Node<T> GetLastNode()
    {
        return this.tail;
    }

    public void AddHeadNode(T data)
    {
        if (size == 0)
        {
            Node<T> node = new Node<T>(data);
            Head = node;
            Tail = node;
        }
        else
        {
            Node<T> node = new Node<T>(data);
            node.Next = Head;
            Head = node;
        }
      
        this.size++;
    }

    public void AddTailNode(T data)
    {
        if (size == 0)
        {
            Node<T> node = new Node<T>(data);
            Head = node;
            Tail = node;
        }
        else
        {
            Node<T> node = new Node<T>(data);
            Tail.Next = node;
            Tail = node;
        }

        this.size++;
    }

}
