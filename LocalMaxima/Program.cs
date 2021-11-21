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
            const int size = 30, maxValue = 30;
            string locMax = "";
            int[] myArray = new int[size];
            Random rand = new Random();

            for (int i = 0; i < size; i++)
            {
                myArray[i] = rand.Next(maxValue);
            }

            for (int i = 0; i < size; i++)
            {
                
                if (i == 0)
                {
                    if (myArray[i+1]<myArray[i])
                    {
                        locMax += myArray[i] + " ";
                        i++;
                    }
                    
                }
                else if (i == size-1)
                {
                    if (myArray[i-1]<myArray[i])
                    {
                        locMax += myArray[i] + " ";
                    }
                }
                else
                {
                    if (myArray[i] > myArray[i-1] && myArray[i] > myArray[i+1])
                    {
                        locMax += myArray[i] + " ";
                        i++;
                    }
                }
            }
            
            Console.WriteLine(locMax);
            Console.ReadLine();
        }
    }
}
