using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure_and_algorithm.demo2
{
    class LoopNode
    {
        public LoopNode(int data)
        {
            this._data = data;
        }
            
        private int _data;
        private LoopNode _next;

        public LoopNode After(LoopNode node)
        {
            LoopNode currentNode = this;
            LoopNode nextNode = this._next;
            while (nextNode != null)
            {
                nextNode = currentNode._next;
            }
            currentNode._next = node;
            
            return currentNode;
        }
        public LoopNode RemoveNext()
        {
            LoopNode endNode=this;
            LoopNode nextNode = this.Next().Next();
            this._next = nextNode;
            while (nextNode._next != null)
            {
                nextNode = nextNode._next;
                endNode = nextNode;
            }
            return endNode;
        }
        public void Delete(LoopNode node)
        {
            LoopNode prevNode = this;
            LoopNode currentNode = this;
            while (currentNode != null)
            {
                if(currentNode.Next() == node)
                {
                    LoopNode nextNode = currentNode.Next().Next();
                    prevNode = currentNode;
                    currentNode = nextNode;
                    break;
                }
                else
                {
                    LoopNode nextNode = currentNode.Next();
                    currentNode = nextNode;
                }
            }
            prevNode._next = currentNode;
            //return prevNode;
        }
        public LoopNode Next()
        {
            return this._next;
        }
        public LoopNode Getdata()
        {
            Console.WriteLine(this._data);
            return this;
        }
        public void Show()
        {
            LoopNode currentNode = this;
            while (currentNode != null)
            {
                Console.Write(currentNode._data);
                currentNode = currentNode.Next();
            }
            Console.WriteLine();
        }
    }
}
