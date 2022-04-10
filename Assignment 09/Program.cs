using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_09
{
    internal class Program
    {
        static void DisplayPersonalInfo()
        {
            string name = "Lucas", school = "Centennial College", program = "Software Engineering Technology",
                favCourse = "COMP100";
            Console.WriteLine("My name is: " + name);
            Console.WriteLine("My school is: " + school);
            Console.WriteLine("The program I am studying is: " + program);
            Console.WriteLine("My favourite course is: " + favCourse);
        }
        static void CalculateTuition()
        {
            Console.Write("Enter the number of courses you are taking:  ");
            int course = Convert.ToInt32(Console.ReadLine());
            double cost = course * 569.99;
            Console.WriteLine("Your total tuition fee is:  " + cost);
        }

        static void CalculateAreaOfTriangle()
        {
            Console.Write("Enter the base for triangle :  ");
            double triBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter the height for triangle :  ");
            double triHeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double area = (triBase * triHeight) / 2;
            Console.WriteLine($"base of triangle: {triBase}, height: {triHeight}, area: {area}");
        }

        static void CalculateAreaOfCircle()
        {
            Console.Write("Enter the radius for circle:  ");
            Console.WriteLine();
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.Pow(radius, 2) * Math.PI;
            Console.WriteLine("The area of the circle with {0} radius is:  {1}", radius, area);
        }

        static void CalculateSaleComission()
        {
            Console.Write("Enter your sales figure: ");
            double sales = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double commission = 0;
            if (sales > 1000)
            {
                commission = (sales - 1000) * 0.25;
            }
            Console.WriteLine($"your sales is: {sales} and your commission is: {commission:f2}");
        }

        static void DisplaySineTable()
        {
            Console.Write("Enter the starting value: ");
            double startValue = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the step size: ");
            double stepSize = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("*****************************");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{startValue}\t\t{Math.Sin(startValue):F4}");
                Console.WriteLine();
                startValue += stepSize;
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("==========Lucas's Computer Systems============");
            Console.WriteLine();
            Console.WriteLine("|       1.Display Personal Information       |");
            Console.WriteLine();
            Console.WriteLine("|       2.Calculate Tuition                  |");
            Console.WriteLine();
            Console.WriteLine("|       3.Calculate Area Of A Circle         |");
            Console.WriteLine();
            Console.WriteLine("|       4.Calculate The Area Of A Triangle   |");
            Console.WriteLine();
            Console.WriteLine("|       5.Calculate Sales Commission         |");
            Console.WriteLine();
            Console.WriteLine("|       6.Display Sine Table                 |");
            Console.WriteLine();
            Console.WriteLine("|       0.End program                        |");
            Console.WriteLine();
            Console.WriteLine("|                                            |");
            Console.WriteLine();
            Console.WriteLine("==============================================");
            Console.WriteLine();
            Console.Write("         Enter the number of your choice ->   ");
        }
        static void Main(string[] args)
        {
            int userInput = 0;
            do { 
                DisplayMenu();
                string temp = Console.ReadLine();
                Console.WriteLine();

                if (int.TryParse(temp, out userInput))
                {
                    switch (userInput)
                    {
                        case 0:
                            Console.WriteLine("Thank you for using");
                            Console.ReadLine();
                            Environment.Exit(0);
                            break;
                        case 1:
                            DisplayPersonalInfo();
                            break;
                        case 2:
                            CalculateTuition();
                            break;
                        case 3:
                            CalculateAreaOfCircle();
                            break;
                        case 4:
                            CalculateAreaOfTriangle();
                            break;
                        case 5:
                            CalculateSaleComission();
                            break;
                        case 6:
                            DisplaySineTable();
                            break;
                        default:
                            Console.WriteLine("Please enter an integer in 0 ~ 6: ");
                            break;
                    }
                }
                else 
                {
                    Console.WriteLine("Invalid input  TRY AGAIN!");
                    userInput = 1;
                }

                Console.WriteLine("Press any key to continue");
                Console.ReadLine();
                Console.Clear();
            }while (userInput != 0);
            Console.ReadLine();
        }

    }
}
