using System;
using System.Collections.Generic;

namespace queraTst1
{
    class Program
    {
        static void Main(string[] args)
        {
            var XOR = 0;
            var n = 10;
            var nummbers = new int[n];
            var alone = new List<int>();
            for (int i = 0; i < nummbers.Length; i++)
            {
                nummbers[i]= new Random().Next(1, 10);
            }
            Console.Write("array : ");
            foreach (var item in nummbers)
            {
                Console.Write(item + " " );
            }
            Console.WriteLine("\n");

            var index = 0;
            foreach (var num in nummbers)
            {
                int copy = 0;
                var root = num;
                for (int i = 0; i < nummbers.Length; i++)
                {
                    if (!(i==index))
                    {
                        if (nummbers[i] == root)
                        {
                            copy++;
                        }
                    }

                }
                if (copy == 0)
                {
                    alone.Add(root);
                }
                index++;

            }
            foreach ( var num  in alone)
            {
                XOR += num;
            }
            Console.Write("alone nummbers : ");

            foreach (var item in alone)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("xor : " + XOR);
        }
    }
}
