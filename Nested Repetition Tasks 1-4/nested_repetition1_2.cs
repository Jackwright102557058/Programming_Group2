/*
 * Created by SharpDevelop.
 * User: 102557058
 * Date: 21/03/2019
 * Time: 2:56 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Nested_Repetition
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Please Enter your Name ");
			String name = Console.ReadLine();
			
			int counter = 0;
			int counter2 = 0;
			
			while (counter < 10) {
				counter2 = 0;
				
				while (counter2 < 10) {
					Console.Write(name);
					counter2 += 1;
				}
				
				Console.WriteLine();
				
				counter += 1;
					
			}
			Console.WriteLine("Later Nerd");
			Console.ReadKey();
		}
	}
}