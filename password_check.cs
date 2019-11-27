using System;

namespace Review
{
  public class Program
  {
    public static void Main(string[] args)
    {
      /* use this space to write your own short program! 
      Here's what you learned:

      BOOL TYPE: bool variableName
      COMPARISON OPERATORS: ==, <, >, <=, >=
      LOGICAL OPERATORS: &&, ||, !

      Good luck! */
      Console.WriteLine("Enter a password :");
      string password = Console.ReadLine();
	  Console.WriteLine(password);
	  
	 if (password.ToUpper() == password) {
		 Console.WriteLine("yes");
	 } else {
		 Console.WriteLine("no");
	 }
    }
  }
}