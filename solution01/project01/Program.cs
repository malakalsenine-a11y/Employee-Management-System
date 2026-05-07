using System;
using System.Collections.Generic;

namespace project01
{
    internal class Program
    {
        // ===============================
        //1. Create a Base Class
        // ===============================


        public class Employee
        {
            //Private fields (Encapsulation)
            private int id;
            private double salary;

            // Property for ID with validation

            public int Id
            {
                get { return id; }
                set
                {
                    if (value > 0)
                        id = value;
                }
            }

            // Property for Salary with validation

            public double Salary
            {
                get { return salary; }
                set
                {
                    if (value >= 0)
                        salary = value;
                }
            }

            // Public properties

            public string Name { get; set; }
            public string Department { get; set; }

            // Virtual method (Polymorphism)

            public virtual void Work()
            {
                Console.WriteLine("Employee is working");
            }

        }


        // =============================================
        //2. Create Derived Classes (A. Developer)
        // =============================================

        public class Developer : Employee
        {
            public string ProgrammingLanguage { get; set; }

            // Override Work method

            public override void Work()
            {
                Console.WriteLine("Developer is writing code");
            }
        }


        // ==============================================
        //2. Create Derived Classes (B. Designer)
        // ==============================================

        public class Designer : Employee
        {
            public string DesignTool { get; set; }

            // Override Work method

            public override void Work()
            {
                Console.WriteLine("Designer is creating UI designs");
            }
        }

        static void Main(string[] args)
        {

            // ===============================
            //3.Demonstrate Polymorphism
            // ===============================

            List<Employee> employees = new List<Employee>();


            Developer dev = new Developer
            {
                Id = 1,
                Name = "Malak",
                Department = "IT",
                Salary = 1000,
                ProgrammingLanguage = "C#"
            };

            Designer des = new Designer
            {
                Id = 2,
                Name = "Anoud",
                Department = "UI/UX",
                Salary = 900,
                DesignTool = "Figma"
            };

            employees.Add(dev);
            employees.Add(des);

            // Loop through employees
            foreach (var emp in employees)
            {
                emp.Work(); // Polymorphism happens here
            }
        }
    }
}