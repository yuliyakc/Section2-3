using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpFundas
{
    public class Dictionary
    {
        static void Main(string[] args)
        {
            List<string> lstMonths = new List<string>();
            lstMonths.Add("January");
            lstMonths.Add("February");
            lstMonths.Add("March");

            var February = lstMonths[1];
            var March = lstMonths[2];

            var months = new Dictionary<int, string>
            {
                {1, "January"},
                {2, "February"},
                {3, "March"}

            };
            months[4] = "April";
            months.Add(5, "May");

            Console.WriteLine(months); 

        }
    }
}
