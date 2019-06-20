/*
 * Created by SharpDevelop.
 * User: 102557058
 * Date: 18/04/2019
 * Time: 10:57 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace array_names{

    class Program{
        
        public static void Main(string[] args){
            
            int count = 0;
            string[] namesArray = new string[5];
              
            while (count < namesArray.Length) {
                string name = Console.ReadLine();
                namesArray[count] = name;
                count++;
            }
            
            count = 0;
            while (count < namesArray.Length) {
                string name = namesArray[count];
                Console.WriteLine("Hello " + name);
                count++;
            }
            
            Console.ReadLine();
        }
    }
}