using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure_and_algorithm.demo2
{
    class DoubleNode
    {
        public DoubleNode(int data)
        {
            this._data = data;
            _prev = this;
            _next = this;
            _test = 1;
        }
        private int _data;
        private DoubleNode _prev;
        private DoubleNode _next;
        private int _test;
        public void After(DoubleNode node)
        {
            DoubleNode nextNext = _next;
            this._next = node;
            node._next = nextNext;
            node._prev = this;
            nextNext._prev = node;
            
        }
        public void Modify(DoubleNode node)
        {
            node._test = 9;
        }
        public void ShowTest()
        {
            Console.WriteLine(this._test); 
        }
        public void Show()
        {
            DoubleNode currentNode = this;
            while (currentNode != null)
            {
                Console.Write(currentNode._data);
                currentNode = currentNode.Prev();
            }
        }
        public DoubleNode Next()
        {
            return this._next;
        }
        public DoubleNode Prev()
        {
            return this._prev;
        }
    }
}
