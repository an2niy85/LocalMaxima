using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalMaxima
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 30;
            const int maxValue = 30;
            string locMax = "";
            int[] myArray = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                myArray[i] = random.Next(maxValue);
            }

            if (myArray[1] < myArray[0])
            {
                locMax += myArray[0] + " ";
            }
            
            if (myArray[myArray.Length-2] < myArray[myArray.Length-1])
            {
                locMax += myArray[myArray.Length-1] + " ";
            }

            for (int i = 1; i < myArray.Length-2; i++)
            {
                if (myArray[i] > myArray[i - 1] && myArray[i] > myArray[i + 1])
                {
                    locMax += myArray[i] + " ";
                    i++;
                }
            }
            
            Console.WriteLine(locMax);
            Console.ReadLine();
        }
    }
}
