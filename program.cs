using System;

namespace PolymorphismAssignment
{
    // 1. Create an interface called IQuittable and have it define a void method called Quit().
    public interface IQuittable
    {
        void Quit();
    }

    // 2. Have your Employee class inherit that interface and implement the Quit() method.
    public class Employee : IQuittable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} has quit the company.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.FirstName = "John";
            emp.LastName = "Doe";

            // 3. Use polymorphism to create an object of type IQuittable
            IQuittable quittableEmployee = emp;

            // Call the Quit() method
            quittableEmployee.Quit();

            Console.ReadLine();
        }
    }
}
