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
                    if (value >= 0 ) 
                        salary = value;
                }
            }

            // Public properties

            public string Name { get; set; }
            public string Department { get; set; }

            // Virtual method (Polymorphism)

            public virtual void work()
            {
                Console.WriteLine("Employee is working");
            }

        }


        // ===============================
        //2. Create Derived Classes (A. Developer)
        // ===============================

        public class Developer : Employee
        {
            public string ProgrammingLanguage { get; set; }

            // Override Work method

            public override void work()
            {
                Console.WriteLine("Developer is writing code");
            }
        }


        // ===============================
        //2. Create Derived Classes (B. Designer)
        // ===============================

        public class Designer : Employee
        {
            public string DesignTool { get; set; }

            // Override Work method

            public override void work()
            {
                Console.WriteLine("Designer is creating UI designs");
            }









            static void Main(string[] args)
        {

        }
    }
}
