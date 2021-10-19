using System;

class SelectionAndIteration
{

  public SelectionAndIteration()
  {
    Console.WriteLine();
    Console.WriteLine("My name is: Viktor I am a student of the HT 21 semester!");
    Console.WriteLine();

    ShowStringLength();
    Console.WriteLine();

    MakeMyDay();
    Console.WriteLine();

    StartSumNumbers();
  }

  private void ShowStringLength()
  {
    Console.WriteLine("Let me calculate the lenght of strings for you!");

    string readInput = string.Empty;
    bool done = false;
    do 
    {
      Console.WriteLine("Give me a text of any lenght, or press Enter to exit");
      readInput = Console.ReadLine();

      if (readInput == "") 
      {
        done = true;
        break;
      }

      if (readInput.Length > 1) 
      {
        Console.WriteLine(readInput.ToUpper());
        Console.WriteLine($"Number of chars = {readInput.Length}\n");
      }
    }
    while (!done);
    Console.WriteLine("OK. You pressed Enter. See you again!");
  }

  private void MakeMyDay()
  {
    Console.WriteLine("I can predict your day for you. Give me a number between 1 and 7: ");

    try
    {
      GetDay();
    }
    catch (System.FormatException e)
    {
      Console.WriteLine($"{e.Message}. Try again...");
      GetDay();
    }
  }

  private void StartSumNumbers()
  {
    Console.WriteLine();
    
    Console.WriteLine("Give me the start number:");
    try
    {
      /* Get the start number */
      int startNum = int.Parse(Console.ReadLine());
      /* Get the end number */
      Console.WriteLine("Give me the end number:");
      int endNum = int.Parse(Console.ReadLine());
      int sum;

      if (startNum < endNum)
      {
        /* Calculate the sum */
        sum = SumNumbers(startNum, endNum);
      } else {
        /* Swap numbers if startNum is less than endNum */
        int tempNum = startNum;
        startNum = endNum;
        endNum = tempNum;
        /* Calculate the sum */
        sum = SumNumbers(startNum, endNum);
      }

      Console.WriteLine($"Result: {sum}");
    }
    catch (System.FormatException e)
    {
      Console.WriteLine($"{e.Message}. Try again...");
      StartSumNumbers();
    }
  }

  private int SumNumbers(int start, int end)
  {
    int sum = 0;
    for (int i = start; i <= end; i++)
    {
      sum = sum + i;
    }
    return sum;
  }

  private void GetDay()
  {
    int number = int.Parse(Console.ReadLine());

    if (InRange(1, 7, number))
    {
      switch(number)
      {
        case 1:
          Console.WriteLine("Monday: keep calm! You can fell aprt!");
          break;
        case 2:
          Console.WriteLine("Tuesday and Wednsday break your heart!");
          break;
        case 3:
          Console.WriteLine("Tuesday and Wednsday break your heart!");
          break;
        case 4:
          Console.WriteLine("Thursday, Uuush, still one day to Friday!");
          break;
        case 5:
          Console.WriteLine("It's Friday! You are in love!");
          break;
        case 6:
          Console.WriteLine("Saturday, do nothing and do plenty of it!");
          break;
        case 7:
          Console.WriteLine("And Sunday always comes too soon!");
          break;
      }
    } else {
      Console.WriteLine("Not in a good mode? This is not a valid date, try again...");
      GetDay();
    }
  }

  /* Helpers */
  private static bool InRange(int a,int b,int number)
  {
    return (a <= number && number <= b);
  }
}
