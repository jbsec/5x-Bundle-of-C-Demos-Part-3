using System;

namespace StringApplication {

  class Program {

    static void Main(string[] args) {
      //string literal and string concat
      string fname, lname;
      fname = "Rowan";
      lname = "Atkison";

      char []letters= { 'H', 'e', 'l', 'l', 'o'};
      string [] sarray= { "Hello", "From", "Tutorials", "Point"};

      string fullname = fname + lname;
      Console.WriteLine("Full Name: {0}", fullname);

      //string constructor of hello letters
      string greetings = new string(letters);
      Console.WriteLine("Greetings: {0}", greetings);

      //methods returning string hello tutorials bit
      string message = String.Join(" ", sarray);
      Console.WriteLine("Message: {0}", message);

      //format method to convert value
      DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
      string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
      Console.WriteLine("Message: {0}", chat);
    }
  }
}