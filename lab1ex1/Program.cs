using System;

namespace lab1ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
            paralelipiped dreptunghic, va afisa volumul lui */

            Console.WriteLine("Calculam volumul unui paralelipiped dreptunghic.");
            Console.WriteLine("Introduceti lungime");

            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti latime");

            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti inaltime");

            int lenght = int.Parse(Console.ReadLine());

            int volume = width * height * lenght;
            Console.WriteLine("volumul paralelipipedului este: " + volume);
        }
    }
}
