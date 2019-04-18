/*
 * Created by SharpDevelop.
 * User: 102557058
 * Date: 18/04/2019
 * Time: 2:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;   
namespace Nested2  
{  
   class Program  
   {  
      static void Main(string[] args)  
      {  
      Console.WriteLine("How many x's do you want?");
      string uinput = Console.ReadLine();
      
      int vinput = int.Parse(uinput);
    
       	
      int count = 0;
      int Value = 0;
      while(count < vinput) {
      	string x = "";
      	int Count2 = vinput;
      	while(Count2 > Value){
      		x = x + "x";
      		Count2 = Count2 -1;
      	}
      	Console.WriteLine(x);
      	Value = Value +1;
      	count++;}
      	
      	Console.ReadKey();
      	
      }
      }  
 }