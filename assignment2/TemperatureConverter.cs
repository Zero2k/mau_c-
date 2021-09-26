using System;

class TemperatureConverter
{

  public TemperatureConverter()
  {
    Console.Clear();

    Start();
  }

  private void Start()
  {
    int choice = -1;

    while (choice != 0)
    {
      ShowMenu();
      try
      {
        choice = int.Parse(Console.ReadLine());
      }
      catch (System.Exception)
      {
        Console.WriteLine("Invalid option, try again!");
      }
      

      switch (choice)
      {
        case 0:
          /* Exit loop */
          break;
        case 1:
          /* Display table of celsius to fahrenheit */
          ShowTableCelsiusToFahrenheit();
          break;
        case 2:
        /* Display table of fahrenheit to celsius */
          ShowTableFahrenheitToCelsius();
          break;
      }
    }
  }

  private void ShowMenu()
  {
    Console.WriteLine("--------------------------------");
    Console.WriteLine();
    Console.WriteLine("     TEMPERATURE CONVERTER      ");
    Console.WriteLine();
    Console.WriteLine("--------------------------------");
    Console.WriteLine();
    Console.WriteLine("  Celsius to Fahrenheit   :  1  ");
    Console.WriteLine("  Fahrenheit to Celsius   :  2  ");
    Console.WriteLine("  Exit                    :  0  ");
    Console.WriteLine();
    Console.WriteLine("--------------------------------");
    Console.WriteLine();
    Console.Write("  Your choice: ");
  }

  private void ShowTableCelsiusToFahrenheit()
  {
    const int columns = 2;
    const int max = 100;
    int p = 0;

    for (int i = 0; i <= max; i += 4)
    {
      double result = CelsiusToFahrenheit(i);
      Console.Write("{0,6:f2} C = {1,6:f2} F", i, result);

      p++;
      if ((p % columns == 0) && (p >= columns))
        Console.WriteLine();
    }
  }

  private void ShowTableFahrenheitToCelsius()
  {
    const int columns = 2;
    const int max = 100;
    int p = 0;

    for (int i = 0; i <= max; i += 4)
    {
      double result = FahrenheitToCelsius(i);
      Console.Write("{0,6:f2} F = {1,6:f2} C", i, result);

      p++;
      if ((p % columns == 0) && (p >= columns))
        Console.WriteLine();
    }
  }

  private double CelsiusToFahrenheit(double celsius)
  {
    return 9.0 / 5.0 * celsius + 32.0;
  }

  private double FahrenheitToCelsius(double fahrenheit)
  {
    return 5.0 / 9.0 * (fahrenheit - 32);
  }
}
