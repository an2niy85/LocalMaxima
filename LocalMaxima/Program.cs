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
            string localMaxima = "";
            int[] myArray = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                myArray[i] = random.Next(maxValue);
            }

            if (myArray[1] < myArray[0])
            {
                localMaxima += myArray[0] + " ";
            }
            
            for (int i = 1; i < myArray.Length-2; i++)
            {
                if (myArray[i] > myArray[i - 1] && myArray[i] > myArray[i + 1])
                {
                    localMaxima += myArray[i] + " ";
                    i++;
                }
            }

            if (myArray[myArray.Length - 2] < myArray[myArray.Length - 1])
            {
                localMaxima += myArray[myArray.Length - 1] + " ";
            }

            Console.WriteLine(localMaxima);
            Console.ReadLine();
        }
    }
}
