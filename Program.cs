using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_WK_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayAstrick(); // Calling the method
        }

        static void DisplayAstrick()
        {
            string star = "*";
            char space = ' ';
            int index = 1;
            int counter = 0;


            Console.Write("Input Number of stars: "); // Ask the user to input number 
            int a = Convert.ToInt32(Console.ReadLine());  // 
            Console.WriteLine();

            while (index <= a)
            {
                while (counter <= a)
                {
                    Console.Write(star);
                    counter++;
                   

                }
            }
        }
    }
}