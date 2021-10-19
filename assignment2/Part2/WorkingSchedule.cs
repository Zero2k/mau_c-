using System;

class WorkingSchedule
{
  public WorkingSchedule()
  {
    Start();
  }

  private void Start()
  {
    int choice = -1;

    while (choice != 0)
    {
      ShowMenu();
      bool input = int.TryParse(Console.ReadLine(), out choice);
      /* TryParse ensure the input is a number. However, I decided to use try catch in SelectionAndIteration.cs & TemperatureConverter.cs
         as I think it's easier to understand and simpler to use than TryParse. */
      if (!input)
      {
        Console.WriteLine("\nPlease enter 1 - 2 or 0 to exit the program.");
        choice = -1;
      }

      switch (choice)
      {
        case 0:
          /* Exit loop */
          break;
        case 1:
          /* Display table of celsius to fahrenheit */
          ShowWeekendsToWork();
          break;
        case 2:
        /* Display table of fahrenheit to celsius */
          ShowNightsToWork();
          break;
        default:
          Console.WriteLine("You entered a value that's not valid. Try again...");
          break;
      }
    }
  }

  private void ShowMenu()
  {
    Console.WriteLine("\n------------------------------------");
    Console.WriteLine();
    Console.WriteLine("  1. Show a list of weekends to work  ");
    Console.WriteLine("  2. Show a list of nights to work    ");
    Console.WriteLine("  0. Exit                             ");
    Console.WriteLine();
    Console.WriteLine("--------------------------------------");
    Console.WriteLine();
    Console.Write("Your choice: ");
  }

  private void ShowWeekendsToWork()
  {
    /* Start work at week (2) and work every third weeks. */
    CreateSchedule(2, 3);
  }

  private void ShowNightsToWork()
  {
    /* Start work at week (1) and work every four weeks. */
    CreateSchedule(1, 4);
  }

  /* Create schedule - This function takes two arguments. The frist one, startWeek which is the week the schedule should start from, 
     e.g start week 2 of 52. It also takes a everyWeek which is the weeks that the work will take place. E.g if the work shift start at week 2 then the next week to work will be 5 then 8, 11, etc */
  private void CreateSchedule(int startWeek, int everyWeek) {
    const int columns = 4;
    const int max = 52;
    int p = 0;

    for (int i = startWeek; i <= max; i += everyWeek)
    {
      /* Print Week + week number */
      GetWeek(i);

      p++;
      if ((p % columns == 0) && (p >= columns))
        Console.WriteLine();
    }
  }

  private void GetWeek(int week)
  {
    Console.Write("Week {0,7}\t", week);
  }
}
