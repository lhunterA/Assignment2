using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _200425671A2
{    /// <summary>
     /// Assignment 2 for COMP1098 of the Winter Semester. 
     /// Created by: Lindsay Hunter
     /// Completed: April 12, 2020
     /// A basic memory calaculator (the simpler one)
     /// Memeory Calculator class that extends the calculator class 
     /// </summary>

    class MemoryCalculator : Calculator
    {
        private String memInput = "";

        /// <summary>
        /// Setter and Getter for the memory input
        /// </summary>
        public String MemInput
        {
            get { return memInput; }
            set { memInput = value; }
        }



         

    }
}
