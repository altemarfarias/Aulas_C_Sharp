﻿// See https://aka.ms/new-console-template for more information
using System;
namespace Aula02
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Jesus é Bom!");
            if(args.GetLength(0)>0){
                Console.WriteLine(args.GetValue(0));
                Console.Write(args.GetValue(1));
            }
        }
    }
}