using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundas
{
    public class toString
    {
        static void Main(string[] args)
        {

            //toString() = converts an object to its string representation so that it is suitable for display

            Car car = new Car("Chevy", "Corvette", 2022, "blue");
            Console.WriteLine(car); 
            Console.ReadKey();
        }
    }
}
class Car
{
    String make;
    String model;
    int year;
    String color;

    public Car(String make, String model, int year, String color)
    { 
        this.make = make;
        this.model = model;
        this.year = year;
        this.color = color;
    
    }

    public override string ToString()
    {
        return "This is a " + make + " " + model;
    }

}

