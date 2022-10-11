using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkList<T>
{
    protected Node<T> head;
    protected Node<T> tail;
    protected Node<T> current;
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

    public Node<T> DeleteAtHead()
    {
        /*if (isEmpty())
            throw new RuntimeException("Empty Linked List.");*/
        this.current = this.head;
        if (size == 1)
            this.head = this.tail = null;
        else
        {
            this.head = this.current.getNext();
        }
        this.size--;
        return this.current;
    }

    public bool isEmpty()
    {
        return this.head == null && this.tail == null;
    }

    public T Next(T Checkpoint)
    {
        T Next = Head.Data;
        Node<T> current = Head;

        while (current != null)
        {
            if (current.Data.Equals(Checkpoint))
            {
                Next = current.Next.Data;
                break;
            }
            else
            {
                current = current.Next;
            }
        }
        Debug.Log(Next);
        return Next;
    }

    public void Display()
    {
        Node < T > temp = head;
        Debug.Log(temp);
    }
}
