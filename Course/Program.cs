﻿using System;

namespace Somar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, soma;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            soma = n1 + n2;

            Console.WriteLine("SOMA = " + soma);



        }
    }
}
