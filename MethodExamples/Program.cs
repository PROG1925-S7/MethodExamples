using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MethodExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            double circleArea;
            string enteredName = "Bobby";
            string enteredPin = "1234";
            //PrintSignature();
            //AreaRectangle();
            //MaxEfficiency();

            Console.Write("Please enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter a number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Add(num1, num2);
            WelcomeUser(enteredName, enteredPin);

            result = Area(10, 5);
            Console.WriteLine($"The area is {result}");

            circleArea = Area(3);
            Console.WriteLine($"The area is {circleArea}");

            Console.ReadKey();
        }

        // 1. Print a signature to the screen
        static void PrintSignature()
        {
            Console.WriteLine("Your's truly \n\nGrace Hopper");
        }

        // 2. Create a method to calculate the area of a rectangle
        static void AreaRectangle()
        {
            int width = 10;
            int height = 20;
            int area = width * height;

            Console.WriteLine(area);
        }

        // 3. Create a method that will determine and display the maximum of 3 values 
        static void Max()
        {

        }

        static void MaxEfficiency()
        {
            int num1, num2, num3, max;

            num1 = 10;
            num2 = 20;  
            num3 = 30;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            //test 100 million times
            for (int i = 0; i < 100000000; i++)
            {
                max = num1;

                if (num2 > max)
                {
                    max = num2;
                }

                if (num3 > max)
                {
                    max = num3;
                }

                //if (num1 > num2 && num1 > num3)
                //{
                //    max = num1;
                //}

                //if (num2 > num1 && num2 > num3)
                //{
                //    max = num2;
                //}

                //if (num3 > num1 && num3 > num2)

                //{
                //    max = num2;
                //}

            }

            sw.Stop();
            Console.WriteLine($"{sw.ElapsedMilliseconds}");
        }

        // 4. Create an Add method, that accepts 2 int parameters
        static void Add(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine($"{x} + {y} = {sum}");
        }

        // 5. Create a method called WelcomeUser, that accepts
        //    2 string parameters, name and pin. If the PIN is
        //    1234 the program welcomes the user. If not an
        //    error message is displayed.
        static void WelcomeUser(string name, string pin)
        {
            if(pin == "1235")
            {
                Console.WriteLine($"Welcome {name}");
            }
            else
            {
                Console.WriteLine("Please go away");
            }
        }

        // 6a. Create a method called Area, that accepts 2 int
        //     parameters, (x and y), uses them to determine the
        //     area of a rectangle , and then returns the 
        //     result back to the method call.

        static int Area(int length, int width)
        {
            int area = length * width;
            return area;
        }

        // 6b. Create another method called Area, to find the area
        //     of a circle.
        static double Area(double radius)
        {
            // area = 3.14 * radius * radius
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        static double Area(double length, double width)
        {
            double area = length * width;
            return area;
        }
    }
}
