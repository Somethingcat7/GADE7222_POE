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
                if (current.Next == null)
                {
                    Next = Head.Data;
                    break;
                }
                else
                {
                    Next = current.Next.Data;
                    break;
                }
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

    public Node<T> SearchForNodeIndex(int index)
    {
        Node<T> returnNode = null;
        Node<T> currentNode = Head;

        int inIndex = 0;

        while (current != null)
        {
            if (index == inIndex)
            {
                returnNode = currentNode;
                break;
            }
            else
            {
                currentNode = currentNode.getNext();
            }
            inIndex++;
        }
        return returnNode;
    }
    
    public Node<T> SearchForNode(T search)
    {
        Node<T> returnNode = null;

        Node<T> currentNode = head;

        while (currentNode != null)
        {
            if (currentNode.Data.Equals(search))
            {
                returnNode = currentNode;
                break;
            }
            currentNode = currentNode.getNext();
        }

        return returnNode;
    }

    public T SearchForIndex(int index)
    {
        T returNode = default(T);

        Node<T> currentNode = Head;

        int inindex = 0;

        while (currentNode != null)
        {
            if (index == inindex)
            {
                returNode = currentNode.Data;
                break;
            }

            currentNode = currentNode.getNext();
            inindex++;
            
        }

        return returNode;

    }
    
    
}
