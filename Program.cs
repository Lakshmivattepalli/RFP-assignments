using System;
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
            int numOfWorkingDays = 20;
            int totalWorkingDays = 20;
            int empHrs = 0;
            int empWage = 0;
            int totalEmpHr = 0;
            int totalSalary = 0;

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
            public void EmpPartTime()
            {
                int randomCheck = obj.Next(0, 3);
                if (randomCheck == is_Full_Time)
                {
                    empHrs = 8;
                    Console.WriteLine("Employee has worked full day");
                }
                else if (randomCheck == is_Part_Time)
                {
                    empHrs = 4;
                    Console.WriteLine("Employee has worked half day");
                }
                empWage = empHrs * empRatePerHr;
                Console.WriteLine(" The salary of this Employee is:" + empWage);
            }
            public void WageSwitch()
            {
                int randomCheck = obj.Next(0, 3);
                switch (randomCheck)
                {

                    case 1:

                        empHrs = 8;
                        Console.WriteLine("Employee is working for full day");
                        break;


                    case 2:

                        empHrs = 4;
                        Console.WriteLine("Employee is working for half-day");
                        break;
                    case 0:

                        empHrs = 0;
                        Console.WriteLine("Emplyee is absent");
                        break;

                }
                empWage = empHrs * empRatePerHr;
                Console.WriteLine(" The salary of an employee for one day is:" + empWage);
            }
            public void Wagemonth()
            {
                for (int day = 1; day <= totalWorkingDays; day++)
                {
                    int randomCheck = obj.Next(0, 3);
                    switch (randomCheck)
                    {
                        case 1:

                            empHrs = 8;
                            break;

                        case 2:

                            empHrs = 4;
                            break;

                        case 0:

                            empHrs = 0;
                            break;
                    }
                    empWage = empHrs * empRatePerHr;
                    totalSalary = (totalSalary + empWage);

                    Console.WriteLine("Total salary of an employee per month is " + totalSalary);

                }
            }
            public void totalWorkingHrMonth()
            {
                while (totalEmpHr < maxRatePerMonth && totalWorkingDays < numOfWorkingDays)
                {
                    totalWorkingDays++;
                    int randomCheck = obj.Next(0, 3);
                    switch (randomCheck)
                    {
                        case -1:
                            {
                                empHrs = 8;
                                break;
                            }
                        case -2:
                            {
                                empHrs = 4;
                                break;
                            }
                        case -0:
                            {
                                empHrs = 0;
                                break;
                            }
                    }
                    totalEmpHr = (totalEmpHr + empHrs);
                }
                int totalSalary = (totalEmpHr * empRatePerHr);
                Console.WriteLine(" the total salary of an emoloyee is" + totalSalary);
                Console.WriteLine(" total working hours of an employee is" + totalEmpHr);
                Console.WriteLine("total sorking days of an employee is" + totalWorkingDays);
            }
        }

       
    }
}
      
