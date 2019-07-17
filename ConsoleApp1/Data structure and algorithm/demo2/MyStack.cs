using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure_and_algorithm.demo2
{
    class MyStack
    {
        private int[] _elements;
        public MyStack()
        {
            _elements = new int[0];
        }
        public void Push(int element)
        {
            int[] newStack = new int[_elements.Length+1];
            for(int i=0; i < _elements.Length; i++)
            {
                newStack[i] = _elements[i];
            }
            newStack[_elements.Length] = element;
            _elements = newStack;
        }
        public int Pop()
        {
            if (_elements.Length == 0)
            {
                throw new Exception("Stack is empty");
            }
            int element = _elements[_elements.Length - 1];
            int[] newStack = new int[_elements.Length-1];
            for(int i = 0; i < _elements.Length - 1; i++)
            {
                newStack[i] = _elements[i];
            }
            _elements = newStack;
            return element;
        }
        public int Peek()
        {
            if (_elements.Length == 0)
            {
                throw new Exception("Stack is empty");
            }
            return _elements[_elements.Length-1];
        }
        public bool IsEmpty()
        {
            return _elements.Length == 0;
        }
        public void Show()
        {
            if (_elements.Length == 0)
            {
                throw new Exception("Stack is empty");
            }
            foreach (int j in _elements)
            {
                Console.WriteLine(j);
            }
        }
    }
}
