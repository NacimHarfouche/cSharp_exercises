using System;

namespace PlanetCalculations
{
  class Program
  {
    static void Main(string[] args)
    {  
      // Your Age
      int userAge = 30;

      // Length of years on Jupiter (in Earth years)
      double jupiterYears = 11.86;

      // Age on Jupiter
      double jupiterAge = userAge / jupiterYears;

      // Time to Jupiter
      double journeyToJupiter = 6.142466;

      // New Age on Earth
      double newEarthAge = userAge + journeyToJupiter;

      // New Age on Jupiter
      double newJupiterAge = newEarthAge / jupiterYears;

      // Log calculations to console
      Console.WriteLine("My current earth age : " + userAge);
      Console.WriteLine("My age on jupiter : " + jupiterAge);
      Console.WriteLine("My new earth age after a journey to jupiter : " + newEarthAge);
      Console.WriteLine("My new jupiter age after a journey to jupiter : " + newJupiterAge);
      
    }
  }
}