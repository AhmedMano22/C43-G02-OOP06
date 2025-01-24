using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session06Demo.Abstraction
{
    public abstract class Person
    {
        int Age;
        public abstract string? Name { get; set; }
        public abstract void sayHello();

        public void printName()
        {
            Console.WriteLine("Name: Person");
        }
    }


    public class Student : Person
    {
        public override string? Name { get ; set  ; }

        public override void sayHello()
        {
            Console.WriteLine("Hello, I am a student");
        }
    }
}
