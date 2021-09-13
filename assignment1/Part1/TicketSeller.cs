using System;

class TicketSeller
{
  private string name;
  private double price = 100;
  private int numOfAdults;
  private int numOfChildren;
  private double amountToPay;

  public void Start()
  {
    Console.WriteLine("Welcome to KIDS' FAIR!");
    Console.WriteLine("Children get always a 75% discount!\n");

    /* Get user input */
    ReadInput();
    /* Display receipt */
    DisplayReceipt();
  }

  private int ReadInputAsInt() {
    string input = Console.ReadLine();
    /* Convert string to int and return it */
    int intInput = Int16.Parse(input);

    return intInput;
  }

  private void ReadInput()
  {
    Console.WriteLine("Your name please:\n");
    name = Console.ReadLine();

    Console.WriteLine("Number of adults:");
    numOfAdults = ReadInputAsInt();
    
    Console.WriteLine("Number of children:");
    numOfChildren = ReadInputAsInt();
  }

  private double CalculateTotalAmount()
  {
    double amountAdults = numOfAdults * price;
    double amountChildren = numOfChildren * (price * 0.25);
    amountToPay = amountAdults + amountChildren;

    return Math.Round(amountToPay, 2);
  }

  private void DisplayReceipt()
  {
    Console.WriteLine(" +++ Your receipt +++");
    Console.WriteLine($" +++ Amount to pay = {CalculateTotalAmount()}\n");
    Console.WriteLine($" +++ Thank you {name} and please come back! +++");
  }
}
