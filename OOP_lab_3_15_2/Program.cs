using System;
using System.IO;

namespace OOP_lab_3_15_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("D:/Zavd2.txt");

            string str = file.ReadLine();

            string[] elements = str.Split(" ");

            int n = int.Parse(elements[1]);

            int k = elements[0].Length;

            Console.WriteLine("Кiлькiсть лiтер: {0}\n", k);

            for (int i = elements[0].Length - 1; i >=0; --i)
            {
                Console.WriteLine(elements[0][i]);
            }

            Console.WriteLine("\n{0}", n + 10);
        }
    }
}
