using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    using System;

    public class Employee
    {

        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Salary: Rs {Salary}");
        }
    }

    public class Manager : Employee
    {

        public decimal Bonus { get; set; }

        public Manager(string name, decimal salary, decimal bonus) : base(name, salary)
        {
            Bonus = bonus;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Bonus: Rs {Bonus:C}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee("John Doe", 50000);
            Console.WriteLine("Employee Information:");
            employee.DisplayInfo();

            Console.WriteLine();

            Manager manager = new Manager("Jane Smith", 80000, 10000);
            Console.WriteLine("Manager Information:");
            manager.DisplayInfo();
        }
    }
}
