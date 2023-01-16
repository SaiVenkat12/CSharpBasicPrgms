using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose the options \n1.Calculator \n2.Day of the Week"); 
            int choose=Convert.ToInt32(Console.ReadLine());

            switch(choose)
            {
                case 1:
                    Console.WriteLine("   Calculator  ");

                    Console.WriteLine("Enter the First Number: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Second Number: ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    Calculator.operations(a, b);
                    break;
                case 2:
                    Console.WriteLine("   Day of the Week Program");
                    Console.WriteLine("Choose the Number: ");
                    int dayNumber=Convert.ToInt32(Console.ReadLine());

                    WeekDay.DayOfTheWeek(dayNumber);
                    break;
                default:
                    Console.WriteLine("Choose the Correct Number");
                    break;
                    

            }
        }
    }
}