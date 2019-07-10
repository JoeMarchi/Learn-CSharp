using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure_and_algorithm.demo1
{
    class MyArray
    {
        private int[] _elements;
        public MyArray()
        {
            _elements = new int[0];
        }
        public int Size()
        {
            return _elements.Length;
        }
        public void Add(int element)
        {
            int[] newarr = new int[_elements.Length + 1];
            for (int i = 0; i < _elements.Length; i++)
            {
                newarr[i] = _elements[i];
            }
            newarr[_elements.Length] = element;
            _elements = newarr;
        }
        public void Insert(int dst,int element)
        {
            int[] newarr = new int[_elements.Length + 1];
            for(int i = 0; i < newarr.Length; i++)
            {
                if (i < dst)
                {
                    newarr[i] = _elements[i];
                }
                else if(i==dst)
                {
                    newarr[i] = element;
                }
                else
                {
                    newarr[i] = _elements[i - 1];
                }
            }
                _elements = newarr;
        }
        public void Get(int dst)
        {
            Console.WriteLine(_elements[dst]);
        }
        public void Set(int dst,int element)
        {
            _elements[dst] = element;
        }
        public void Delete(int dst)
        {
            int[] newarr = new int[_elements.Length - 1];
            for(int i = 0; i < newarr.Length; i++)
            {
                if (i < dst)
                {
                    newarr[i] = _elements[i];
                }
                else
                {
                    newarr[i] = _elements[i + 1];
                }
            }
            _elements = newarr;
        }
        public void Show()
        {
            foreach(int j in _elements)
            {
                Console.WriteLine(j);
            }
        }
        public void Search(int target)
        {
            int index = -1;
            for (int i = 0; i < _elements.Length; i++)
            {
                if (_elements[i] == target)
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine(index);
        }
        public void BinarySearch(int target)
        {
            int begin = 0;
            int end = _elements.Length - 1;
            int i = 0;
            while(i > _elements.Length)
            {
                if (target == _elements[(begin + end) / 2])
                {
                    Console.WriteLine(_elements[(begin + end) / 2]);
                }
                else if (target >_elements[(begin + end) / 2])
                {
                    
                }
            }
        }
    }
}
