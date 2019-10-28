using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_2._5
{
    class Calculator
    {
        public bool DivisibleByFive (int number)
        {
            if (number % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
