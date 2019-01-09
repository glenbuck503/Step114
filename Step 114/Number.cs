using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_114
{
    public class Number
    {
        public void Addition(int firstNumber)
        {
            int firstNumberPlus = firstNumber + 10;
            Console.WriteLine(firstNumberPlus);
        }

        public void Addition(decimal secondNumber)
        {
            decimal secondNumberPlus = secondNumber + .5m;
            Console.WriteLine(secondNumberPlus);
        }


        public void Addition(string thirdNumber)
        {
            int thirdNumberPlus = Convert.ToInt32(thirdNumber) +500;
            Console.WriteLine(thirdNumberPlus);

                



        }
           
    }
}
