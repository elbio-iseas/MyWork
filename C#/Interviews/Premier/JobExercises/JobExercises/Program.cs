using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobExercises
{   
    class Program
    {
        
        static void OnBase()
        {
            for (int i = 1; i < 101; i++)
            {
                Console.Write(i);
                if ((i % 7 == 0) && (i % 3 == 0))
                {
                    Console.WriteLine(" OnBase");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine(" On");
                }
                else if (i % 7 == 0)
                {
                    Console.WriteLine(" Base");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        
        }

        static char[] myArrayReverse(char[] ArrayIn)
        {
            Array.Reverse(ArrayIn);

            return ArrayIn;
        }
        static char[] myManualArrayReverse(char[] oneArray)
        {
            int length = oneArray.Length;

            if (length > 0)

            {
                if (length > 1)

                {
                    int first = 0;

                    int last = length - 1;

                    char temp = ' ';

                    for (int i = 0; i < (length / 2); i++)
                    {
                        temp = oneArray[first];

                        oneArray[first] = oneArray[last];

                        oneArray[last] = temp;

                        first++;

                        last--;
                    }
                }
            }

            return oneArray;
        }
        static void primes(int start, int end)
        {

            for (int a = start; a < end + 1; a++)
            {
                int prime = 1;

                for (int b = 2; b <= a-1; b++)
                { 
                    if ( a % b == 0)
                    {
                        prime = 0;
                    }
                }

                if ( prime == 1 )
                {
                    Console.WriteLine(a);
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            char[] charArray = { 'H', 'a', 'n', 'n', 'a', 'h' };
            char[] charSecondArray = { 'S','p','i','d','e','r','m','a','n' };

            OnBase();
            Console.ReadLine();

            for (int i = 0; i < 6; i ++)
            {
                Console.Write(charArray[i]);
            }
            Console.WriteLine();

            charArray = myArrayReverse(charArray);

            for (int i = 0; i < 6; i++)
            {
                Console.Write(charArray[i]);
            }
            Console.WriteLine();
            Console.ReadLine();

            primes(2, 99);
            Console.ReadLine();

            for (int i = 0; i < charSecondArray.Length ; i++)
            {
                Console.Write(charSecondArray[i]);
            }

            Console.WriteLine();
            Console.ReadLine();

            charSecondArray = myManualArrayReverse(charSecondArray);

            for (int i = 0; i < charSecondArray.Length; i++)
            {
                Console.Write(charSecondArray[i]);
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
