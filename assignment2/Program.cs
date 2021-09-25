using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Selection and iteration in C#";
            SelectionAndIteration warmupObj = new SelectionAndIteration();

            Console.WriteLine("Press any key to continue!");
            Console.ReadLine();

            Console.Title = "Fahrenheit and Ceslsius Converter";
            /* TemperatureConverter converter = new TemperatureConverter(); */

            Console.WriteLine("Press any key to exit!");
            Console.ReadLine();
        }
    }
}
