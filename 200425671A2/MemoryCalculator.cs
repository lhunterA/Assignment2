using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _200425671A2
{
    /// <summary>
    /// Memeory Calculator class that extends the calculator class 
    /// </summary>
    class MemoryCalculator : Calculator
    {
        private String memInput = "";
        public String MemInput
        {
            get { return memInput; }
            set { memInput = value; }
        }

         

    }
}
