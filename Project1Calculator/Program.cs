using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,c;
            Console.Write("Enter 1st Number : ");
            a = Convert.ToInt16(Console.ReadLine()); //Reading 1st Number
            Console.Write("Enter 2nd Number : ");
            b = Convert.ToInt16(Console.ReadLine()); //Reading 2nd Number  
            Console.WriteLine("\n1. Addition \n2. Substraction \n3. Multiplication \n4. Division");
            Console.WriteLine("\nEnter your choice :");
            c = Convert.ToInt16(Console.ReadLine()); ////Reading a Choice
            switch (c)
            {
                case 1:
                    Console.WriteLine("Addition Of Two Numbers : " + (a + b));
                    break;
                case 2:
                    Console.WriteLine("Subtraction Of Two Numbers : " + (a - b));
                    break;
                case 3:
                    Console.WriteLine("Multiplicaion Of Two Numbers : " + (a * b));
                    break;
                case 4:
                    Console.WriteLine("Division Of Two Numbers : " + (a / b));
                    break;
                default:
                    Console.WriteLine("Wrong Choice");
                    break;
            }
            Console.ReadLine();
        }
    }
}
