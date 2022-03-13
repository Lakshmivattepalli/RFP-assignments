using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, Welcome to the Employee Wage Computations Program");
            Console.ReadLine();
        }
        internal class Class1
        {
            int is_Full_Time = 1;
            int is_Part_Time = 2;

              Random obj = new Random();

            public void Employee()
            {
                int empCheck = obj.Next(0, 2);
                if (empCheck == is_Full_Time)
                {
                    Console.WriteLine("Employee is Present");
                }
                else
                {
                    Console.WriteLine("Employee is Absent");
                }
            }

        }
    }
}

