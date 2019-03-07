/*
 * Created by SharpDevelop.
 * User: 102557058
 * Date: 7/03/2019
 * Time: 6:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace over18
{
	class Program
	{
		public static void Main(string[] args)
		{
			int age;
			string input;
			
			Console.WriteLine("Please Enter Your Age!");
			input = Console.ReadLine();
			
			age = int.Parse(input);
			
			if(age >= 18) {
				Console.WriteLine("Welcome To The Pub!");
			} 
			else {
				if(age <= 0) {
					Console.WriteLine("What The Fuck?!?!?");
				} else {
					Console.WriteLine("Go Watch A Disney Movie Kiddo");
				}
				
			}
			
			
			Console.Write("Press any key to continue? ");

			Console.ReadKey(true);
			
			
		}
	}
}