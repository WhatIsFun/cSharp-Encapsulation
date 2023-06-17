namespace cSharp_PropertiesAndEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car("Corolla", "2018", "red");
            //car.StartEngine();
            //car.moveCar();
            //Car car2 = new Car("civic", null, "Green");

            //car = car2;
            //car.color = "Blue";
            //Console.WriteLine(car.model);

            //int[] someNumbers = new int[10];

            //someNumbers.Length = 5;

        



            Person person1 = new Person("Ahmed",25,"Nizwa");
            person1.SetName("Mohammed");
            person1.SetAge(24);
            person1.SetAddress("Ibri");

            Console.WriteLine("Person Name: "+ person1.GetName);
            Console.WriteLine("Age: "+ person1.GetAge);
            Console.WriteLine("Address: "+ person1.GetAddress);

            //Q3
            //Employee Class
            Employee employee20 = new Employee(2235, "Mohammed", "IT Trainer", 435);
            Console.WriteLine("Employee Details");
            Console.WriteLine("Employee Name: "+ employee20.GetName);
            Console.WriteLine("Employee Position: " + employee20.GetPosition);
            Console.WriteLine("Employee Salary: " + employee20.GetSalary);

            employee20.GetId();
            employee20.GetName();
            employee20.UpdatePosition("IT Manager");
            employee20.UpdateSalary(1200);
            employee20.GetPosition();
            employee20.GetSalary();
            Console.WriteLine("********************");
            Console.WriteLine("New Employee Details");
            Console.WriteLine("Employee Details");
            Console.WriteLine("Employee Name: " + employee20.GetName);
            Console.WriteLine("Employee Position: " + employee20.GetPosition);
            Console.WriteLine("Employee Salary: " + employee20.GetSalary);
            Console.WriteLine("Employee ID: "+ employee20.id);
            Console.WriteLine("Employee Name: " + employee20.name);
            Console.WriteLine("Employee Position: " + employee20.position);
            Console.WriteLine("Employee Salary: " + employee20.salary);



        }
    }
}