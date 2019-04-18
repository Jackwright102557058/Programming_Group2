/*
 * Created by SharpDevelop.
 * User: 102557058
 * Date: 18/04/2019
 * Time: 10:40 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

using System.Collections.Generic;

public class Hello{    
	public static void Main(){
		
		int check;        
		int input;
		
		List<int> numbers = new List<int>();        
		numbers.Add(int.Parse(Console.ReadLine()));        
		numbers.Add(int.Parse(Console.ReadLine()));        
		numbers.Add(int.Parse(Console.ReadLine()));        
		numbers.Add(int.Parse(Console.ReadLine()));        
		numbers.Add(int.Parse(Console.ReadLine()));
		
		Console.WriteLine("Numbers have been recorded, enter the number you wish to check");
		
		check = Convert.ToInt32(Console.ReadLine());
		
		if (numbers.Contains(check)){            
			Console.WriteLine("That number is part of the list");        
		}        
		else{            
			Console.WriteLine("That number is not part of the list");        
		}       
		
		Console.ReadKey();
	}
}