﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure_and_algorithm.demo3
{
    class Recursive
    {
        public void Print(int i)
        {
            Console.WriteLine(i);
            Print(i - 1);
        }
    }
}
