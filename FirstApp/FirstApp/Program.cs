using CodeFlow;
using DataTypes;
using FirstLib;
using Newtonsoft;
using Newtonsoft.Json;
using Operators;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int x = 0;
            //int a = 7 / x;
            //TestMeth(null);
            //return;
            JsonSerializer serializer = new JsonSerializer();
            Employee employee = new Employee();
            employee.Name = "Ion;";
            Console.WriteLine(employee.Name + " - " + employee.FirstName);
            FirstAppClass firstAppClass = new FirstAppClass();
            var employee2 = new Employee("Ion", "Popescu");
            Console.WriteLine(employee2.Name + " - " + employee2.FirstName);

            var blue = Color.Green;

            Flow flow = new Flow();
            flow.Continue();

            Operator @operator = new Operator();
            @operator.Incremetor();
            @operator.Ternar(15);
            @operator.Ternar(22);
            @operator.NullColeascing(null);
            @operator.NullColeascing(5);

            string data = null;
            @operator.NullConditional(data);
            data = "Mama are mere!";
            @operator.NullConditional(data);

            Console.ReadKey();
        }

        private static void TestMeth(Employee employee)
        {
            if(employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }
            Console.WriteLine($"Employee {employee.FirstName} {employee.Name}");
            Console.WriteLine("Employee {0} {1}", employee.FirstName, employee.Name);
        }
    }
}