/*
 * Created by SharpDevelop.
 * User: 102557058
 * Date: 18/04/2019
 * Time: 3:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace GuessGame
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			
			int secretnumber;
			Random random = new Random();
			secretnumber = random.Next(1, 25);

			
			
			Console.WriteLine("Hey there! Lets play a little guessing game.");
			
			//Console.WriteLine();
			//Console.WriteLine("The Secret Number is: " + secretnumber);
			//Console.WriteLine();
			
			int guesscounter = 7;

			while (guesscounter != 0) {
				Console.WriteLine("Guess a number between 1 - 25.");
			
				string uinput = Console.ReadLine();
				Console.WriteLine();
				int vinput = int.Parse(uinput);

			
				if (vinput < secretnumber) {
				
					Console.WriteLine("Too Low! Guess a higher value!");
					Console.WriteLine();
					guesscounter = guesscounter - 1;
					Console.WriteLine("You have " + guesscounter + " Left");
					Console.WriteLine();
				} else if (vinput > secretnumber) {
				
					Console.WriteLine("Too High! Guess a lower value!");
					Console.WriteLine();
					guesscounter = guesscounter - 1;
					Console.WriteLine("You have " + guesscounter + " Left");
					Console.WriteLine();
				}
					
				else if (vinput == secretnumber) {
						Console.WriteLine("Wow you got the correct answer, it was " + secretnumber + ".");
						Console.WriteLine("You still had " + guesscounter + " guesses left");
						Console.WriteLine("Thanks for playing!");
						Console.ReadKey();
						Environment.Exit(0);
				}
				
				
				}
			Console.WriteLine("Sorry, you're out of guesses! THanks for playing!");
				Console.ReadKey();
			}
		}
	}