using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class1
    {
       public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {

            //Console.WriteLine($"Yearly Wage: {monthlyWage * numberOfMonthsWorked}");
            //return monthlyWage * numberOfMonthsWorked;

            if (numberOfMonthsWorked == 12)
                return monthlyWage * (numberOfMonthsWorked + 1);

            return monthlyWage * numberOfMonthsWorked;
        }
        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked,int bonus)
        {
            Console.WriteLine($"Yearly Wage with bonus: {monthlyWage * numberOfMonthsWorked + bonus}");

            return monthlyWage * numberOfMonthsWorked + bonus ;
        }

        public static double CalculateYearlyWage(double monthlyWage, double numberOfMonthsWorked, double bonus)
        {
            Console.WriteLine($"Yearly Wage (double): {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;


        }
    }
}
