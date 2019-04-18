/*
 * Created by SharpDevelop.
 * User: 102557058
 * Date: 18/04/2019
 * Time: 10:59 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Array_adds{

    class Program{
        
        public static void Main(string[] args){
            
            int count = 0;
            int[] numberarray = {34, 5, 67, 1, 99, 34, 44, 78, 34, 0};
            

            int total = 0;
            count = 0;
            while(count < numberarray.Length) {
                total = total + numberarray[count];
                count++;
            }
        
            
            Console.WriteLine("Total is " + total);

            
            Console.ReadLine();
        }
    }
}