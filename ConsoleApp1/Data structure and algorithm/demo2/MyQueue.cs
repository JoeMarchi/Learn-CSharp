using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure_and_algorithm.demo2
{
    class MyQueue
    {
        private int[] _elements;
        public MyQueue()
        {
            _elements = new int[0];
        }
        public void Put(int element)
        {
            int[] newQueue = new int[_elements.Length+1];
            for(int i = 0; i < _elements.Length; i++)
            {
                newQueue[i] = _elements[i];
            }
            newQueue[_elements.Length] = element;
            _elements = newQueue;
        }
        public int Pull()
        {
            if(_elements.Length == 0)
            {
                throw new Exception("Queue is empty");
            }
            int element = _elements[0];
            int[] newQueue = new int[_elements.Length - 1];
            for(int i = 0; i < _elements.Length-1; i++)
            {
                newQueue[i] = _elements[i + 1];
            }
            _elements = newQueue;
            return element ;
            
        }
        public bool IsEmpty()
        {
            return _elements.Length == 0;
        }
        public void Show()
        {
            foreach(int j in _elements)
            {
                Console.WriteLine(j);
            }
        }
    }
}
