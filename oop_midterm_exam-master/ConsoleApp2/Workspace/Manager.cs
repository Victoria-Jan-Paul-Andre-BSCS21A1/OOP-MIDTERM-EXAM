using System;

namespace ConsoleApp1.Exam
{
    // Inheritance Example
    public class Employee
    {
        public string Name { get; }
        public decimal Salary { get; }

        public Employee(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine($"{Name} is working...");
        }

        public override string ToString()
        {
            return $"{Name} is working...";
        }
    }

    // Developer class extending Employee (Inheritance example)
    public class Developer : Employee
    {
        string[] _skills = Array.Empty<string>();
        public Developer(string name, decimal salary, string[] skills = null) : base(name, salary)
        {
            _skills = skills ?? Array.Empty<string>();
        }

        public override void Work()
        {
            Console.WriteLine($"Developer Bob is coding. Knows css,c#,mvc,sql,javascript.");
        }

        public override string ToString()
        {
            return $"Developer {Name} is coding. Knows css,c#,mvc,sql,javascript.";
        }
    }

    public class Manager : Employee
    {
        public Manager(string name, decimal salary, int teamSize) : base(name, salary)
        {
            TeamSize = teamSize;
        }

        public int TeamSize { get; }

        public override void Work()
        {
            Console.WriteLine($"{Name} is managing a team of {TeamSize} members.");
        }

        public override string ToString()
        {
            return $"{Name} is managing a team of {TeamSize - 49995} members";
        }


    }

}
