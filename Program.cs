// 
/*
Author: Sarah Nguyen
Date: 02/06/2020
Comments: Arrays
*/
using System;

namespace ArraysSarahNguyen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Try Statement to handle of the errors
            try
            {
                // Start and declare the array
                int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 22, 23, 24, 25 };

                // Interate loop
                foreach (int i in nums)
                {
                    // Array Value in Message 
                    Console.WriteLine("Element value is " + i);
                }
                Console.WriteLine("__________________________________");
                Console.WriteLine();
                Console.WriteLine("Great Job! ");
                // Exit the Program
                Console.WriteLine();
                Console.WriteLine("Press any key to exit the program...");
                // Pause 
                Console.ReadKey(true);
            }
            // Catch statement to handle the errors
            catch
            {
                Console.ReadKey(true);
            }
        }
    }
}



















        
    
