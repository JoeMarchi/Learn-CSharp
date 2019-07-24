using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure_and_algorithm.demo2
{
    class Node
    {
        public Node(int data)
        {
            this._data = data;
        }
            
        private int _data;
        private Node _next;
        public Node Append(Node node)
        {
            Node currentNode = this;
            while (currentNode.Next() != null)
            {
                Node nextNode = currentNode.Next();
                currentNode = nextNode;
            }
            currentNode._next = node;
            return node;
        }
        public Node RemoveNext()
        {
            Node endNode=this;
            Node nextNode = this.Next().Next();
            this._next = nextNode;
            while (nextNode._next != null)
            {
                nextNode = nextNode._next;
                endNode = nextNode;
            }
            return endNode;
        }
        public void Delete(Node node)
        {
            Node prevNode = this;
            Node currentNode = this;
            while (currentNode != null)
            {
                if(currentNode.Next() == node)
                {
                    Node nextNode = currentNode.Next().Next();
                    prevNode = currentNode;
                    currentNode = nextNode;
                    break;
                }
                else
                {
                    Node nextNode = currentNode.Next();
                    currentNode = nextNode;
                }
            }
            prevNode._next = currentNode;
            //return prevNode;
        }
        public Node Next()
        {
            return this._next;
        }
        public Node Getdata()
        {
            Console.WriteLine(this._data);
            return this;
        }
        public void Show()
        {
            Node currentNode = this;
            while (currentNode != null)
            {
                Console.Write(currentNode._data);
                currentNode = currentNode.Next();
            }
            Console.WriteLine();
        }
        public bool IsLast()
        {
            Console.WriteLine(this._next == null);
            return this._next == null;
        }
    }
}
