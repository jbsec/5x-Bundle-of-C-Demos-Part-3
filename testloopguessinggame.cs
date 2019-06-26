using System;

namespace GuessTheNumber
{
  class Game
  {

  static int UserGuess;
  static int Answer;
  static string EndProg = "No";

    static void Main (string[] args)
    {
      Console.Title = "Guess the number.";

      EntryMessage();
      GenerateRandom();

      while (EndProg == "No") {
        askData();
      }
    }

    static void EntryMessage()
    {
      Console.WriteLine("Welcome to the guessing game. Please press enter.");
      Console.ReadLine();
    }

    static void askData()
    {
      while (EndProg == "No")
      {
        Console.WriteLine(Answer);
        Console.WriteLine("Guess a number between 1 and 1000.");
        UserGuess = Convert.ToInt32(Console.ReadLine());
        WinLose();
      }
      ExitGame();
    }

    
    static void ExitGame()
    {
      string PlayAnswer;
      Console.WriteLine("Thank you using the game!");
      Console.WriteLine("\nWould you like to play again?");
      Console.WriteLine("\nY or N");
      PlayAnswer = Convert.ToString(Console.ReadLine());
      if (PlayAnswer == "Y")
      {
        EndProg = "No";
        askData();
      }
      else if (PlayAnswer == "N")
      {
        Console.WriteLine("\nPress enter to exit.");
        Console.ReadLine();
      }
      else
      {
        Console.WriteLine("\nInvalid input, press enter to exit.");
        Console.ReadLine();
      }
      //Console.WriteLine("Press enter to exit.");
      Console.ReadLine();
    }

    static void GenerateRandom()
    {
      Random random = new Random();
      Answer = random.Next(0,1001);
    }
      static void WinLose() 
      {
        if (UserGuess == Answer)
        {
          Console.WriteLine("Correct number!");
          EndProg="Yes";
        }
        else if (UserGuess > Answer)
        {
          Console.WriteLine("Too high.");
          EndProg="No";
        }
        else if (UserGuess < Answer)
        {
          Console.WriteLine("Too Low.");
          EndProg="No";
        }
        else 
        {
          Console.WriteLine("Invalid answer.");
          EndProg="No";
        }
      }
      // May need to delete
      static void PlayAgain() {
        if (EndProg == "Yes") {
          Console.WriteLine("You want to play again.");
          Console.ReadLine();
        }
      }

  }
}