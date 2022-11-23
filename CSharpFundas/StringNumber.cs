using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundas
{
    public class StringNumber
    {
        static void Main(string[] args)
        {
            string str = "5";
            try
            {
                int a = Convert.ToInt32(str);
                Console.WriteLine("Success");
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }

            int b = 100;
            string str2 = b.ToString();
            Console.WriteLine(str2);
        }
    }
}
