﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Employee emp1 = new Employee();
            emp1.FirstName = "Hans";
            emp1.LastName = "Huber";
            Console.WriteLine("emp1: " + emp1.getLastName() + " " + emp1.getFirstName());
            Employee emp2 = new Employee("Barbara", "Schmidt");
            Console.WriteLine("emp2: " + emp2);
            Console.ReadLine();

            PermanentEmployee pe = new PermanentEmployee();
            ContractEmployee ce = new ContractEmployee("Hans", "Huber", 100.0);
            TempEmployee te = new TempEmployee("Barbara", "Schmidt", 7.5);
            Console.WriteLine(pe);
            Console.WriteLine(ce);
            Console.WriteLine(te);
            Console.ReadLine();
            */

            Employee[] f = new Employee[3];
            f[0] = new PermanentEmployee("Franz", "Schuster", 15000.0);
            f[1] = new ContractEmployee("Hans", "Huber", 100.0);
            f[2] = new TempEmployee("Barbara", "Schmidt", 7.5);
            String hourlyRate;
            foreach (Employee e in f)
            {
                Console.Write(e);
                hourlyRate = e.calculateHourlyRate().ToString("f2");
                Console.WriteLine(" Hourly rate = " + hourlyRate);

            }
            Console.ReadLine();
        }
    }

    class Globals
    {
        public const int DEFAULT_WORK_HOURS_PER_DAY = 8;
        public const int DEFAULT_WORK_DAYS_PER_YEAR = 250;
    }

    interface Payable
    {
        double calculateHourlyRate();
    }


    abstract class Employee : Payable
    {
        private string firstName = "unknown";
        public string FirstName
        {
            set
            {
                firstName = value;
            }
        }
        private string lastName = "unknown";

        public Employee() { }

        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public string LastName
        {
            set
            {
                lastName = value;
            }
        }



        public string getFirstName()
        {
            return firstName;
        }
        public string getLastName()
        {
            return lastName;
        }

        public void setFirstName(string eingabe)
        {
            firstName = eingabe;
        }


        public override string ToString()
        {
            return firstName + " " + lastName;
        }

        //Funktion als Schema fuer die Kinder
        public string VorUndNachName()
        {
            return "First Name: " + firstName + ", Last Name: " + lastName + ", ";
        }

        public abstract double calculateHourlyRate();

    }

    class PermanentEmployee : Employee
    {
        private double salary = 0;

        public PermanentEmployee()
        {

        }

        public PermanentEmployee(string firstName, string lastName, double salary) : base(firstName, lastName)
        {
            this.salary = salary;
        }

        public override string ToString()
        {
            return base.VorUndNachName() + "Salary: " + salary.ToString("F2");
        }

        public override double calculateHourlyRate()
        {
            return salary / (Globals.DEFAULT_WORK_DAYS_PER_YEAR * Globals.DEFAULT_WORK_HOURS_PER_DAY);
        }

        public double getSalary()
        {
            return salary;
        }

        public void setSalary(double eingabe)
        {
            salary = eingabe;
        }
    }

    class ContractEmployee : Employee
    {
        private double dailyRate = 0;

        public ContractEmployee()
        {

        }

        public ContractEmployee(string firstName, string lastName, double dailyRate) : base(firstName, lastName)
        {
            this.dailyRate = dailyRate;
        }

        public override string ToString()
        {
            return base.VorUndNachName() + "Daily Rate: " + dailyRate.ToString("F2");
        }

        public override double calculateHourlyRate()
        {
            return dailyRate / Globals.DEFAULT_WORK_HOURS_PER_DAY;
        }

        public double getDailyRate()
        {
            return dailyRate;
        }

        public void setDailyRate(double eingabe)
        {
            dailyRate = eingabe;
        }
    }

    class TempEmployee : Employee
    {
        private double hourlyRate = 0;

        public TempEmployee()
        {

        }

        public TempEmployee(string firstName, string lastName, double hourlyRate) : base(firstName, lastName)
        {
            this.hourlyRate = hourlyRate;
        }

        public override string ToString()
        {
            return base.VorUndNachName() + "Hourly Rate: " + hourlyRate.ToString("F2");
        }

        public override double calculateHourlyRate()
        {
            return hourlyRate;
        }

        public double getHourlyRate()
        {
            return hourlyRate;
        }

        public void setHourlyRate(double eingabe)
        {
            hourlyRate = eingabe;
        }
    }
}