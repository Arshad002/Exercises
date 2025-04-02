using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    interface IWork
    {
        void DoWork();
        void GetSalary();
    }
    public abstract class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }

        private double salary;
        public double Salary 
        {
            get
            {
                return this.salary;
            } 
            set
            {
                this.salary = value;
            }
        }

        public Employee(string name, int id, double salary) 
        {
            this.Name = name;
            this.ID = id;
            this.Salary = salary;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"ID: {this.ID}");
        }
    }

    public class Manager : Employee, IWork
    {
        public Manager(string name, int id, double salary ) : base(name, id, salary)
        {
        }

        public void DoWork()
        {
            Console.WriteLine("The Manager is overseeing Projects");
        }

        public void GetSalary()
        {
            Console.WriteLine($"Manager's Salary is ${this.Salary}");
        }
    }

    public class Developer : Employee, IWork
    {
        public Developer(string name, int id, double salary) : base(name, id, salary)
        {
        }

        public void DoWork()
        {
            Console.WriteLine("The Developer is writing code");
        }

        public void GetSalary()
        {
            Console.WriteLine($"Developer's Salary is ${this.Salary}");
        }
    }
}
