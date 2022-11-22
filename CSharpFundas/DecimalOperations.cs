using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundas
{
    public class DecimalOperations
    {
        static decimal number1;
        static decimal number2;

        public static void Main()
        {
            number1 = 10.5M;
            number2 = 5.0M; 
        }
        public void Test_Addition()
        {
            decimal sum = number1+number2;
            Console.WriteLine(sum);
        }

    }
}
