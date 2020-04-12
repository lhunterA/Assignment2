using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _200425671A2
{
    /// <summary>
    /// Assignment 2 for COMP1098 of the Winter Semester. 
    /// Created by: Lindsay Hunter
    /// Completed: April 12, 2020
    /// A basic memory calaculator (the simpler one)
    /// Calculator class that extends the calculator class 
    /// </summary>
    public class Calculator
    {
        /// <summary>
        ///  Creating the Addition Method
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>the sum of the two numbers as a String</returns>
        public String Add (decimal num1, decimal num2)
            {
            return (num1 + num2).ToString();
            }

        /// <summary>
        ///  Creating the Subtraction Method
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>the remainder of the two numbers as a String</returns>
        public String Subtract (decimal num1, decimal num2)
        {
            return (num1 - num2).ToString();
        }

        /// <summary>
        ///  Creating the Multiplication Method
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>the multiplication of the two numbers as a String</returns>
        public String Multiply(decimal num1, decimal num2)
        {
            return (num1 * num2).ToString();
        }

        /// <summary>
        ///  Creating the Division Method
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>the division of the two numbers as a String</returns>
        public String Divide(decimal num1, decimal num2)
        {
            return (num1 / num2).ToString();
        }

        /// <summary>
        ///  Creating the SquareRoot Method
        /// </summary>
        /// <param name="num1"></param>
        /// <returns>the squarerroot of one number as a String</returns>
        public String SquareRoot (decimal num1)
        {
            return Math.Sqrt((double)num1).ToString();
        }

        /// <summary>
        ///  Creating the refactor Method
        /// </summary>
        /// <param name="num1"></param>
        /// <returns>the refactorof the two number as a String</returns>
        public String Factor (decimal num1)
        {
            return (1 / num1).ToString();
        }
    }
}
