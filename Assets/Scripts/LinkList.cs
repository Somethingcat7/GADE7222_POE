using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkList<T>
{
    public Node<T> head;

    public Node<T> tail;

    public Node<T> previous;

    public Node<T> current;

    private int size = 0;

    public LinkList()
    {

    }

    public int Size()
    {
        return 0;
    }

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
        Node<T> node = new Node<T>(data);
       
        node.setNext(this.head);
        this.head = node;
        this.tail = node;
      
        this.size++;
    }

    public void AddTailNode(T data)
    {
        Node<T> node = new Node<T>(data);

        this.tail.setNext(node);
        this.tail = node;
        
        this.size++;
    }

}
