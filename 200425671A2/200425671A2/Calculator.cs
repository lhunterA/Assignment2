﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _200425671A2
{
    public class Calculator
    {

        //Create the Addition method
        public double Add (double num1, double num2)
            {
            return num1 + num2;
            }

        public double Subtract (double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public double SquareRoot (double num1)
        {
            return Math.Sqrt(num1);
        }

        public double Factor (double num1)
        {
            return 1 / num1;
        }
    }
}
