using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrepareConsoleLook();
            /* Create pet object */
            Pet petObject = new Pet();
            /* Call Start method to collect info */
            petObject.Start();

            Console.WriteLine("\nPress Enter to start next part!");
            Console.ReadLine();

            /* Create ticket object */
            TicketSeller ticket = new TicketSeller();
            ticket.Start();

            Console.WriteLine("\nPress Enter to start next part!");
            Console.ReadLine();

            /* Create album object */
            Album album = new Album();
            album.Start();

            Console.WriteLine("\nPress Enter to exit");
            Console.ReadLine();
        }

        static void PrepareConsoleLook()
        {
          Console.BackgroundColor = ConsoleColor.White;
          Console.Clear();
          Console.ForegroundColor = ConsoleColor.Black;
          Console.Title = "KIDS FAIR";
        }
    }
}
