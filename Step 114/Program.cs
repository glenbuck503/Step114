using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_114
{
    class Program
    {
        static void Main(string[] args)
        {
            Number resultNumber = new Number();
            resultNumber.Addition(600);
            Console.ReadLine();

            Number resultNumber1 = new Number();
            resultNumber1.Addition(10.5m);

            Number restultNumber3 = new Number();
            Console.WriteLine("Please enter a number");
            string userInput = Console.ReadLine();
            restultNumber3.Addition(userInput);
            

            Console.ReadLine();
        }
    }
}
