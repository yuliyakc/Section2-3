using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundas
{
    class Person
    {
        String name;
        String lastName;
       //method default constructor
        public Person(String name)
        {
            this.name = name;

        }
        public Person(String firstName, String lastName)
        {
            this.lastName = lastName;


        }

        public void getName()
        {
            Console.WriteLine("My name is" + this.name);
        
        }
        public void getData()
        {
            Console.WriteLine("I am inside the method");
        
        }

         public static void Main(string[] args)
        {
            Person p = new Person("Rahul");
            Person p1 = new Person("Rahul", "Amit");
            p.getData();
            p.getName();
            Console.WriteLine("Hello World");
            int a=4;
            Console.WriteLine("number is" +a);

            String name = "Rahul";
            Console.WriteLine("Name is" + name);
            Console.WriteLine($"Name is {name}");

            var age = 23;
            Console.WriteLine("age is" + age);

            dynamic height = 13.2;
            height = "hello";



        }
    }
}
