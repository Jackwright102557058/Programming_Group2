/*
 * Created by SharpDevelop.
 * User: 102557058
 * Date: 7/03/2019
 * Time: 5:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Hello_World
{
	class Program {
		
		public static void Main(string[] args) {
			//declarations
			string message;
			string name;
			int num1;
			int num2;
			string inputStorage1;
			string inputStorage2;
			
			
			//initalisations
     		//message = "Hello";
			//name = Console.ReadLine();
			//num1 = 10;
			//num2 = 20;

			inputStorage1 = Console.ReadLine();
			inputStorage2 = Console.ReadLine();
			
			num1 = int.Parse(inputStorage1);
			num2 = int.Parse(inputStorage2);
			
			int sum = num1 + num2;
			
			Console.WriteLine(sum.ToString());
			
			//Console.WriteLine(message + " " + name);
			//Console.WriteLine(num1 + num2);
					
			Console.Write("Press any key to continue? ");
			Console.ReadKey(true);
		}
	}
}