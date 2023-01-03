using System;

namespace TestWithChatOpenAI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pentru a nu rula toate rezultatele in acelasi timp in consola le am comenta:

            ///Extra:
            //DivizorComun();
            //FizzBuzz();

        }


        //        Supliment 1
        //• Se citesc doua numere de la tastatura.Scrieti un program care va calcula
        //cel mai mare divizor comun al numerelor
        public static void DivizorComun()
        {
            Console.WriteLine("Intoduceti 2 numere pentru a afla cel mai mare divizor comun:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            while (num2 != 0)
            {
                int temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }

            Console.WriteLine("DivizorComun: " + num1);
        }

        //            Supliment 2
        //• Scrie un program care afiseaza numerele de la 1 la N. Daca numarul este
        //multiplu de 3, sa se afiseze Fizz, daca este multiplu de 3 sa se afiseze Buzz,
        //daca e multiplu si de 3 si de 5(ex: 15) sa se afiseze FizzBuzz, in restul
        //cazurilor sa se afiseze numarul.
        public static void FizzBuzz()
        {
            for (int i = 1; i > 0; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
