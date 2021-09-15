using System;

class Album 
{
  private string albumName;
  private string artistName;
  private int numOfTracks;

  public void Start()
  {
    Console.WriteLine("Starting Album Program!\n");
    ReadInput();
    DisplayInfo();
  }

  private int ReadInputAsInt() 
  {
    string input = Console.ReadLine();
    /* Convert string to int and return it */
    int intInput = int.Parse(input);

    return intInput;
  }

  private void ReadInput()
  {
    /* Ask the user to enter album name */
    Console.WriteLine("What is the name of your favorite music album?");
    albumName = Console.ReadLine();

    /* Ask the user to enter artist name */
    Console.WriteLine($"What is the name of the Artist or Band for {albumName}?");
    artistName = Console.ReadLine();

    /* Ask the user for number fo tracks */
    Console.WriteLine($"How many tracks does {albumName} have?");
    numOfTracks = ReadInputAsInt();
  }

  private void DisplayInfo()
  {
    Console.WriteLine($"\nAlbum Name: {albumName}");
    Console.WriteLine($"Artist/Band: {artistName}");
    Console.WriteLine($"Number of Tracks: {numOfTracks}");
    Console.WriteLine("Enjoy listening!");
  }
}
