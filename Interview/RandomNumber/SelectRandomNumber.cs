using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.RandomNumber
{
    public class SelectRandomNumber
    {
        public int[] input { get; set; }
        public int[] frequency { get; set; }

        public void GetInputs()
        {
            input = new int[] { 1, 2, 3 };
            frequency = new int[] { 1, 5, 1 };

        }

        public void Output()
        {
            //var test = new Random();
            //int totalFrequency = 0, rand = 0;

            //for (int i = 0; i < input.Length; i++)
            //{
            //    while (totalFrequency < frequency[i])
            //    {
            //        totalFrequency += frequency[i];
            //        rand = test.Next() * (totalFrequency + frequency[i]);
            //    }

            //    if (rand < totalFrequency)
            //    {
            //        Console.WriteLine(input[i]);
            //        break;
            //    }
            //}
            var maxFrequency = frequency.Max();

            var rand = new Random().Next(0, maxFrequency);
            for (int i = 0; i < input.Length; i++)
            {
                if (frequency[i] >= rand)
                {
                    Console.Write(input[i]);
                    break;
                }
                
            }


            Console.ReadLine();
        }
    }
}
