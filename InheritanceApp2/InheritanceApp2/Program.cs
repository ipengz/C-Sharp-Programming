namespace InheritanceApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee dylon = new Employee("Dylon", 29, "Senior Exec", 13671);
            dylon.DisplayEmployeeInfo();
            Console.ReadKey();
        }

    }

    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public Person(string name, int age) 
        {
            Name = name;
            Age = age;
            Console.WriteLine("Person constructor called");
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    public class Employee : Person 
    {
        public string JobTitle { get; private set; }

        public int EmployeeID { get; private set; }
        public Employee(string name, int age, string jobTitle, int employeeID)
            : base(name,age)
        {
            JobTitle = jobTitle;
            EmployeeID = employeeID;
            Console.WriteLine("Employee constructor called");
        }

        public void DisplayEmployeeInfo() 
        {
            DisplayPersonInfo();
            Console.WriteLine($"Job Title: {JobTitle}, Employee ID: {EmployeeID}");
        }
    }
}
