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
            for ( int i = 0; i < _elements.Length; i++)
            {
                newarr[i] = _elements[i];
            }
            newarr[_elements.Length] = element;
            _elements = newarr;
        }
        public void Insert(int index,int element)
        {
            if (index < 0 || index > _elements.Length)
            {
                throw new Exception("Error");
            }
            int[] newarr = new int[_elements.Length + 1];
            for(int i = 0; i < newarr.Length; i++)
            {
                if (i < index)
                {
                    newarr[i] = _elements[i];
                }
                else if(i==index)
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
        public void Get(int index)
        {
            Console.WriteLine(_elements[index]);
        }
        public void Set(int index,int element)
        {
            _elements[index] = element;
        }
        public void Delete(int index)
        {
            if (index < 0 || index > _elements.Length)
            {
                throw new Exception("Error");
            }
            int[] newarr = new int[_elements.Length - 1];
            for(int i = 0; i < newarr.Length; i++)
            {
                if (i < index)
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
            Console.WriteLine("index1:"+index);
        }
        public void BinarySearch(int target)
        {
            int index = -1;
            int begin = 0;
            int end = _elements.Length - 1;
            while(true)
            {
                int mid = (begin + end) / 2;
                if (begin >= end)
                {
                    break;
                }
                if (target == _elements[mid])
                {
                    index = mid;
                    break;
                }
                else
                {
                    if (target > _elements[mid])
                    {
                        begin = mid + 1;
                    }
                    if (target < _elements[mid])
                    {
                        end = mid - 1;
                    }
                }
            }
            Console.WriteLine("index2:"+index);
        }
    }
}
