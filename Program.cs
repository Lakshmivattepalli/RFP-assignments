﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


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
            int maxRatePerMonth = 100;
            int empRatePerHr = 20;
            int empHrs = 0;
            int empWage = 0;

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

        
        public void DailyWages()
        {
                int empCheck = obj.Next(0, 2);
             if (empCheck == is_Full_Time)
            {
                empHrs = 8;
                Console.WriteLine("Employee worked full day");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Employee is absent");
            }
            empWage = empHrs * empRatePerHr;
            Console.WriteLine("The salary of an Employee is: " + empWage);
        }
        }

        }
    }
      
