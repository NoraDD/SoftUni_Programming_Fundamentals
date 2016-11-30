using System;


namespace _08.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Amanda";
            string lastName = "Jonson";
            int employeeAge = 27;
            char employeeGender = 'f';
            long employeePersonalID = 8306112507;
            int employeeNumber = 27563571;

            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last name: " + lastName);
            Console.WriteLine("Age: " + employeeAge);
            Console.WriteLine("Gender: " + employeeGender);
            Console.WriteLine("Personal ID: " + employeePersonalID);
            Console.WriteLine("Unique Employee number: " + employeeNumber);
        }
    }
}
