using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ReadOnlyExample
    {
        private int _number = 0;
        public int Number
        {
            get { return _number * _number; }
        }
        public ReadOnlyExample(int number)
        {
            _number = number;
        }
    }
}
