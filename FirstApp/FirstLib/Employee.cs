namespace FirstLib
{
    public class Employee
    {
        public Employee()
        {
            Name = "Default";
            FirstName = "Default";
        }
        public Employee(string name, string firstName)
        {
            Name = name;
            FirstName = firstName;
        }

        public string Name { get; set; }
        public string FirstName { get; set; }

    }
}