namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // FirstExample();

        }

        private static void FirstExample()
        {
            Person person = new Person();
            person.Name = "Kalle";

            Employee employee = new Employee();
            employee.Salary = 25;
            employee.Name = "Anna";
            employee.Do();

            Person employee2 = new Employee() { Salary = 34000 };
            employee2.Name = "Owe";



            Admin admin = new Admin();
            admin.Department = "IT";

            Employee admin2 = new Admin() { Department = "finance" };
            Admin castedAdmin = (Admin)admin2;
            Console.WriteLine(castedAdmin.Department);
            castedAdmin.Do();

            Person admin3 = new Admin();
            IPerson admin4 = new Admin();



            var list = new List<IPerson>()
            {
                person, employee, admin2, admin
            };
            //list.Add(person);
            //list.Add(employee2);
            //list.Add(employee);
            //list.Add(admin);

            foreach (Person person1 in list)
            {
                person1.Do();
            }
        }
    }
}