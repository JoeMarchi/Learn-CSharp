using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure_and_algorithm.demo1
{
    class MyArray
    {
        private int[] _array;
        public MyArray()
        {
            _array = new int[0];
        }
        public int Size()
        {
            return _array.Length;
        }
        public void Add(int element)
        {
            int[] newarr = new int[_array.Length + 1];
            for (int i = 0; i < _array.Length; i++)
            {
                newarr[i] = _array[i];
            }
            newarr[_array.Length] = element;
            _array = newarr;
        }
        public void Insert(int index,int element)
        {
            if (index < 0 || index > _array.Length)
            {
                throw new Exception("Error");
            }
            int[] newarr = new int[_array.Length + 1];
            for(int i = 0; i < newarr.Length; i++)
            {
                if (i < index)
                {
                    newarr[i] = _array[i];
                }
                else if(i==index)
                {
                    newarr[i] = element;
                }
                else
                {
                    newarr[i] = _array[i - 1];
                }
            }
                _array = newarr;
        }
        public void Get(int index)
        {
            Console.WriteLine(_array[index]);
        }
        public void Set(int index,int element)
        {
            _array[index] = element;
        }
        public void Delete(int index)
        {
            if (index < 0 || index > _array.Length)
            {
                throw new Exception("Error");
            }
            int[] newarr = new int[_array.Length - 1];
            for(int i = 0; i < newarr.Length; i++)
            {
                if (i < index)
                {
                    newarr[i] = _array[i];
                }
                else
                {
                    newarr[i] = _array[i + 1];
                }
            }
            _array = newarr;
        }
        public void Show()
        {
            foreach(int j in _array)
            {
                Console.WriteLine(j);
            }
        }
        public void Search(int target)
        {
            int index = -1;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == target)
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
            int end = _array.Length - 1;
            while(true)
            {
                int mid = (begin + end) / 2;
                if (begin >= end)
                {
                    break;
                }
                if (target == _array[mid])
                {
                    index = mid;
                    break;
                }
                else
                {
                    if (target > _array[mid])
                    {
                        begin = mid + 1;
                    }
                    if (target < _array[mid])
                    {
                        end = mid - 1;
                    }
                }
            }
            Console.WriteLine("index2:"+index);
        }
    }
}
