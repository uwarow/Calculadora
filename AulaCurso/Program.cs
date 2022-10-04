using System;
using System.Globalization;
using Ubiety.Dns.Core;

namespace AulaCurso
{
    internal class Program
    {



        static void Main(string[] args)
        {
            
            Menu();

            
        }
        static void Menu()
        {
            Console.WriteLine("O que deseja fazer ?");
            Console.WriteLine(" 1 - Soma");
            Console.WriteLine(" 2 - Subtração");
            Console.WriteLine(" 3 - Multiplicação");
            Console.WriteLine(" 4 - Divisão");

            Console.WriteLine("");

            Console.WriteLine("Digite Sua Escolha !");
            short res = short.Parse(Console.ReadLine());



            switch (res)
            {
                case 1 : Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                default: Menu(); break;

            }
            
        }


        static void Soma()
        {
            Console.WriteLine("Primeiro Valor = ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Segundo Valor = ");
            float v2 = float.Parse(Console.ReadLine());

            float res = v1 + v2;
            Console.WriteLine("O resultado da Soma é = " + res);
            Console.ReadLine();
            Console.Clear();

            Menu();

        }

        static void Subtracao()
        {
            Console.WriteLine("Primeiro Valor = ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Segundo Valor = ");
            float v2 = float.Parse(Console.ReadLine());



            float res = v1 - v2;
            Console.WriteLine("O resultado da Subtração é = " + res);
            Console.ReadLine();
            Console.Clear();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Primeiro Valor = ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Segundo Valor = ");
            float v2 = float.Parse(Console.ReadLine());


            float res = v1 * v2;
            Console.WriteLine("O resultado da Multiplicação é = " + res);
            Console.ReadLine();
            Console.Clear();
            Menu();
        }

        static void Divisao()
        {
            Console.WriteLine("Primeiro Valor = ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Segundo Valor = ");
            float v2 = float.Parse(Console.ReadLine());



            float res = v1 / v2;
            Console.WriteLine("O resultado da Divisão é = " + res);
            Console.ReadLine();
            Console.Clear();
            Menu();
        }




        }

          

    }
    

