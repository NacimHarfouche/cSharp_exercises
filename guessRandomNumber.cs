using System;
					
public class Program
{
	public static void Main()
	{
		int randomNumber = new Random().Next(1, 11);
      	Console.WriteLine("Guess the number between 1 to 10 :\n");
		int answerNumber = int.Parse(Console.ReadLine());
      
      	if (randomNumber == answerNumber) {
        	Console.WriteLine("Good Job !!!");
      	} else {
        	Console.WriteLine($"Wrong answer, It was {randomNumber} !!!");
      }
	}
}