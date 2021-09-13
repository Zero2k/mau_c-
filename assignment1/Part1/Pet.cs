using System;

class Pet 
{
  private string name;
  private int age;
  private bool isFemale;

  public void Start()
  {
    ReadInput();
    DisplayInfo();
  }

  private void ReadInput()
  {
    /* Display a welcome message */
    Console.WriteLine("Greeting from Pet class.\n");

    /* Ask the user to name their pet */
    Console.WriteLine("What's the name of your pet? ");
    name = Console.ReadLine();

    /* Ask the user to enter the age of their pet */
    Console.WriteLine($"What's {name}'s age? ");
    string ageAsString = Console.ReadLine();
    /* Convert string to int and assign it to age */
    age = Int16.Parse(ageAsString);

    /* Ask the user if the pet is female or not */
    Console.WriteLine("Is your pet a famale (y/n)? ");
    string yesOrNo = Console.ReadLine();
    /* Covert string to bool */
    bool answer = (yesOrNo == "y") ? true : false;
    /* Assign user answer to isFemale */
    isFemale = answer;
  }

  private void DisplayInfo()
  {
    const string line = "+++++++++++++++++++++++++++++";
    Console.WriteLine(line);
    Console.WriteLine($"Name: {name}. Age: {age}");
    Console.WriteLine("{0} is a good {1}!", name, isFemale ? "girl" : "boy");
    Console.WriteLine(line);
  }
}
