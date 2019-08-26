using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure_and_algorithm.demo3
{
    class Hanoi
    {
        public Hanoi()
        {

        }
        public int Test;
        private int TestP;
        public int HanoiAlgorithm(int n,string source,string targat,string temp)
        {
            if (n > 0)
            {
                HanoiAlgorithm(n - 1, source, temp, targat);
                Console.WriteLine($"{source}=>{targat},{n}");
                HanoiAlgorithm(n - 1, temp, targat, source);
            }
            return 1;
        }
    }
}
