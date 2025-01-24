using Session06Demo.Abstraction;

namespace Session06Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student Std = new Student()
            {
                Name = "John"
            };
            Console.WriteLine(Std.Name);
            Std.printName();
            Std.sayHello();
        }
    }
}
