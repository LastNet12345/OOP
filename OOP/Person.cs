namespace OOP
{
    internal class Person
    {
        public string Name { get; set; } = string.Empty;
        //plus 10 saker till
    }

    internal class Employee : Person
    {
        public int Salary { get; set; }
    }

    internal class Admin : Employee
    {
        public string Department { get; set; }
    }
}