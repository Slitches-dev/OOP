using System;
using System.Collections.Generic;
using System.Text;

namespace LR1
{
    class Figure
    {
        private int _square;

        public Figure()
        {
            _square = 1;
        }

        public Figure(int q)
        {
            _square = q ^ 2;
        }

        public int Square
        {
            get { return _square; }
        }
    }
}
