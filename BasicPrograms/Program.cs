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
            Console.WriteLine("   Calculator  ");
            Console.WriteLine("Enter the First Number: ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number: ");
            int b=Convert.ToInt32(Console.ReadLine());

            Calculator.operations(a, b);
        }
    }
}