using System;
using System.Globalization;
using Ubiety.Dns.Core;

namespace AulaCurso
{
    internal class Program
    {

        
       
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua Idade");
            int idade = Convert.ToInt32(Console.ReadLine());
            if (idade < 18)
            {

                Console.BackgroundColor = ConsoleColor.DarkRed; Console.WriteLine("Usuario sem Permissão"); Console.BackgroundColor = ConsoleColor.Black; 
            }

            if (idade >= 18)
            {

                Console.BackgroundColor = ConsoleColor.DarkGreen; Console.WriteLine("Permissão concedida"); Console.BackgroundColor = ConsoleColor.Black;
            }





        }

          

    }
    }

