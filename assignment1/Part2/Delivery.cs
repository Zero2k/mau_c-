using System;

class Delivery
{
  private string addressFrom;
  private string addressTo;
  private int phone;
  private DateTime createdAt = DateTime.Today;
  private double totalWeight;

  public void Start()
  {
    Console.WriteLine("Greeting, to request a delivery press Enter...");
    Console.ReadLine();
    RequestDelivery();
  }

  private void RequestDelivery()
  {
    Console.WriteLine("You're about to request a delivery, but we need some information about the delivery.");
    Console.WriteLine("Please follow the instructions:\n");

    /* Request pick up location */
    PickUpLocation();

    /* Request delivery location */
    DeliveryLocation();

    /* Request recipient phone number */
    RecipientPhone();

    /* Request the package weight */
    PackageWeight();

    /* Display delivery information */
    DeliverySummary();
  }

  private void PickUpLocation()
  {
    Console.WriteLine("1. Where should we pick up the package?: ");
    addressFrom = Console.ReadLine();
  }

  private void DeliveryLocation()
  {
    Console.WriteLine("2. Where should the package be delivered to?: ");
    addressTo = Console.ReadLine();
  }

  private void RecipientPhone()
  {
    Console.WriteLine("3. Enter recipient phone number (use only numbers):");
    /* Ensure the user enter a number */
    try
    {
      /* Turn the string into a integer */
      phone = int.Parse(Console.ReadLine());
    }
    catch (System.Exception)
    {
      Console.WriteLine("That's not a valid phone number");
      /* Call the function again to allow the user to enter a valid phone number */
      RecipientPhone();
    }
    
  }

  private void PackageWeight()
  {
    Console.WriteLine("4. Enter weight of the package (e.g.: '3,5' if the package weight 3,5 KG):");
    /* Ensure the user enter a number */
    try
    {
      /* Turn the string into a double */
      totalWeight = Convert.ToDouble(Console.ReadLine());
    }
    catch (System.Exception)
    {
      Console.WriteLine("That's not a valid weight");
      /* Call the function again to allow the user to enter a valid weight */
      PackageWeight();
    }
  }

  private void DeliverySummary()
  {
    Console.WriteLine("\nSuccess, you have requested a delivery pick up.");
    Console.WriteLine("Please ensure the following information is correct:\n");

    /* Display collected information */
    Console.WriteLine("DELIVERY SUMMARY:\n");
    Console.WriteLine($"Delivery request created at: {createdAt.ToString("D")}");
    Console.WriteLine($"Your package ({totalWeight} KG) will be picked up at: {addressFrom}");
    Console.WriteLine($"Your package will be deliverd to: {addressTo}");
    Console.WriteLine($"The recipient phone number is: {phone}");
  }
}
