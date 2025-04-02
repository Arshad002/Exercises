using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Encapsulation
            BankAccount myAccount = new BankAccount("Alice", 10000);

            Console.WriteLine($"Account Holder: {myAccount.AccountHolder}");
            Console.WriteLine($"Initial Balance: {myAccount.Balance}");

            myAccount.Deposit(500);
            myAccount.Withdraw(300);
            myAccount.Withdraw(2000);
            myAccount.Withdraw(8000);*/

            /* Abstraction
            Vehicle car = new Car("Toyota");
            car.StartEngine();
            car.DisplayInfo();
            car.StopEngine();

            Console.WriteLine();

            Vehicle bike = new Bike("Yamaha");
            bike.StartEngine();
            bike.DisplayInfo();
            bike.StopEngine();*/

            /*Inheritance
            var manager = new Manager("Alice", 101, 5000);
            manager.DisplayInfo();
            manager.DoWork();
            manager.GetSalary();

            Console.WriteLine();

            var developer = new Developer("Bob", 102, 4000);
            developer.DisplayInfo();
            developer.DoWork();
            developer.GetSalary();
            developer.Salary = 8000;
            developer.GetSalary();*/

            // Polymorphism
            List<Shape> shapes = new List<Shape>()
            {
                new Circle(), 
                new Rectangle(), 
                new Triangle()
            };

            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            shapes[0].Draw(10);
            shapes[1].Draw(10);
        }
    }
}
