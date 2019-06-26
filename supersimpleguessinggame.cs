using System;

class MainClass {
  public static void Main (string[] args) {
    Random rand = new Random();
    int hid = rand.Next(1,100);
    int guess = 101;
    while (guess !=hid)
    {
      Console.WriteLine("Guess a number between 1 and 100.");
      guess = Convert.ToInt32(Console.ReadLine());

      if(guess > hid)
      {
        Console.WriteLine("Too high. Guess again.");
      }
      else if (guess < hid)
      {
        Console.WriteLine("Too low. Guess again.");
      }
      else
      {
        Console.WriteLine("Correct number!");
      }
    }
  Console.WriteLine("Press any key to exit.");
  Console.ReadKey();
  }
}