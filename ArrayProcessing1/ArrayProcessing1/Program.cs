using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProcessing1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayList = new int[100];
            int[] frequencyofOccurence = new int[100];
            int n, i, j, ctr;


            Console.Write("Give the input of number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arrayList[i] = Convert.ToInt32(Console.ReadLine());
                frequencyofOccurence[i] = -1;
            }
            for (i = 0; i < n; i++)
            {
                ctr = 1;
                for (j = i + 1; j < n; j++)
                {
                    if (arrayList[i] == arrayList[j])
                    {
                        ctr++;
                        frequencyofOccurence[j] = 0;
                    }
                }

                if (frequencyofOccurence[i] != 0)
                {
                    frequencyofOccurence[i] = ctr;
                }
            }
            Console.Write("\nThe frequencyofOccurence of all elements of the array : \n");
            for (i = 0; i < n; i++)
            {
                if (frequencyofOccurence[i] != 0)
                {
                    Console.Write("{0} occurs {1} times\n", arrayList[i], frequencyofOccurence[i]);
                }
            }
        }
    }
}
    

