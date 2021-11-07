using System;

namespace Day_14_Problems
{
    public class LinkedListOperations<T>
    {
        public Node<T> head;

        public void add(T data)
        {
            Node<T> node = getNode(data);
            if (head == null)
                head = node;
            else
            {
                Node<T> temp = head;

                while (temp.next != null)
                    temp = temp.next;

                temp.next = node;
            }
            Console.WriteLine("{0} inserted into link list", node.Data);
        }

        public void addSort(T data)
        {
            Node<T> node = getNode(data);

            if (head == null || head.Data >= node.Data)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node<T> temp = head;

                while (temp.next != null && temp.next.Data < node.Data)
                {
                    temp = temp.next;
                }
                node.next = temp.next;
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into link list", node.Data);
        }

        private Node<T> getNode(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.next = null;
            return newNode;
        }

        public void display()
        {
            if (head == null)
                Console.WriteLine("List is empty");
            else
            {
                Node<T> temp = head;
                while (temp != null && temp.Data != null)
                {
                    Console.WriteLine(temp.Data + "\t");
                    temp = temp.next;
                }
            }
        }

        public void InsertAtFirst(T data)
        {
            Node<T> node = getNode(data);

            if (head == null)
                head = node;
            else
            {
                Node<T> temp = head;
                head = node;
                head.next = temp;
            }
            Console.WriteLine("{0} inserted into link list", node.Data);
        }

        public void InsertAfter(T specifiedNodeData, T data)
        {
            Node<T> node = getNode(data);

            if (head == null)
                head = node;
            else
            {
                Node<T> searchedNode = head;

                while (!searchedNode.Data.Equals(specifiedNodeData))
                {
                    searchedNode = searchedNode.next;
                }
                Node<T> tempNode = searchedNode.next;
                searchedNode.next = node;
                searchedNode.next.next = tempNode;
                Console.WriteLine("{0} inserted into link list", node.Data);
            }
        }

        public void RemoveFirst()
        {
            if (head == null)
                Console.WriteLine("List is empty");
            Console.WriteLine("{0} removed from link list", head.Data);
            head = head.next;

        }

        public void RemoveLast()
        {
            if (head == null && head.next == null)
                Console.WriteLine("List is empty");
            Node<T> newNode = head;

            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            Console.WriteLine("{0} removed from link list", newNode.next.Data);
            newNode.next = null;
        }

        public void search(T data)
        {
            while (head != null)
            {
                if (head.Data.Equals(data))
                    Console.WriteLine("{0} is foundin liked list.", data);
                head = head.next;
            }
        }

        public void Remove(T data)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Node<T> temp = head;

                Node<T> previous = null;

                while (!temp.Data.Equals(data))
                {
                    previous = temp;
                    temp = temp.next;
                }
                Console.WriteLine("{0} removed from link list", temp.Data);
                previous.next = temp.next;
            }
        }
    }
}





namespace Day_14_Problems
{
    public class Node<T>
    {
        public dynamic Data;

        public Node<T> next;

        public Node(T data)
        {
            this.Data = data;
        }

    }
}

