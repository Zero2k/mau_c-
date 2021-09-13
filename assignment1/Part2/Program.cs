using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrepareConsoleLook();

            Delivery delivery = new Delivery();
            delivery.Start();
        }

        static void PrepareConsoleLook()
        {
          Console.Clear();
          Console.Title = "Delivert App";
        }
    }
}
