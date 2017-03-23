using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interview.RandomNumber;

namespace Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the Type of Program to Execute:");
            var randomNumber = new SelectRandomNumber();

            while (true)
            {
                var programType = Console.ReadLine();
                randomNumber.GetInputs();
                randomNumber.Output();
            }
        }
    }
}
