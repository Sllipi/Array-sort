using System;
using System.Linq;

namespace Big_element
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            byte randMin = 1;
            byte randMax = 50;
            byte[] bigElement = new byte[10];
            byte identicalElement = 0;
            for (byte i = 0; i < bigElement.Length; i++)
            {
                bigElement[i] = (byte)rand.Next(randMin, randMax);
                Console.Write(bigElement[i] + " ");
                for (byte k = 0; k < bigElement.Length; k++)
                {
                    if (bigElement[i] < bigElement[k])
                    {
                        identicalElement = bigElement[i];
                        bigElement[i] = bigElement[k];
                        bigElement[k] = identicalElement;
                    }
                }
            }
            Console.WriteLine("\nНовый массив");
            for (int l = 0; l < bigElement.Length; l++)
            {
                Console.Write(bigElement[l] + " ");

            }
        }
    }
}
