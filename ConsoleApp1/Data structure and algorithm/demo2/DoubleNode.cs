using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure_and_algorithm.demo2
{
    class DoubleNode
    {
        public DoubleNode(int date)
        {
            this._date = date;
            _prev = this;
            _next = this;
        }
        private int _date;
        private DoubleNode _prev;
        private DoubleNode _next;
        public void After(DoubleNode node)
        {
            _prev._next = node;
            node._next = _prev;

        }
    }
}
