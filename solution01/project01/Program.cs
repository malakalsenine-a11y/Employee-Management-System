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

       





        static void Main(string[] args)
        {

        }
    }
}
