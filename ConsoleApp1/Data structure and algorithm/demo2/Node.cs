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
        public Node Next()
        {
            return this._next;
        }
        public void Getdata()
        {
            Console.WriteLine(this._data);
        }
    }
}
