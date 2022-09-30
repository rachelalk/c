using System;

namespace FavoriteNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      // Ask user for fave number
      Console.Write("Enter your favorite number!: ");
     


      // Turn that answer into an int
      //ReadLine is always a string so using inbuilt function convert allows us to get around this
      int faveNumber = Convert.ToInt32(Console.ReadLine());

      Console.Write($"I like {faveNumber} too!");


    }
  }
}
