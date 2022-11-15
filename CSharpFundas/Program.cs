using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundas
{
    class Program :Program4
    {
        String name;
        String lastName;
       //method default constructor
        public Program(String name)
        {
            this.name = name;

        }
        public Program(String firstName, String lastName)
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
        static void Main1(string[] args)
        {
            Program p = new Program("Rahul");
            Program p1 = new Program("Rahul", "Amit");
            p.getData();
            p.getName();
            p.SetData();
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
