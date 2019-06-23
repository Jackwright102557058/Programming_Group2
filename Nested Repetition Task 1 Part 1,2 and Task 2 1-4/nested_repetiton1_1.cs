/*
 * Created by SharpDevelop.
 * User: 102557058
 * Date: 21/03/2019
 * Time: 4:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ex1_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Enter Your Name: ");
			string name = Console.ReadLine();
			Console.WriteLine();
			
			Console.Write("Enter the number of times you want your name to print: ");
			string usernumber = Console.ReadLine();
			Console.WriteLine();
			
			int counter = 0;
			int usercount;
			
			usercount = int.Parse(usernumber);
			
			while (counter < usercount) {
				
				Console.WriteLine(name);
				counter += 1;
					
			}
			
			Console.WriteLine();
			
			Console.WriteLine("Here's your stupid names.");
			
			Console.WriteLine();
			
			Console.ReadLine();
			Console.WriteLine();
			
			Console.WriteLine("Please Leave.");
			
			Console.ReadKey(true);
		}
	}
}