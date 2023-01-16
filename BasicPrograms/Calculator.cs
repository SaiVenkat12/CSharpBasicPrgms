using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    public class Calculator
    {
        public static void operations(int a,int b)
        {
            int c;
            Console.WriteLine("Choose the options \n1.Addition \n2.Subtraction \n3.Multiplication \n4.Division");
            int option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    c = a + b;
                    Console.WriteLine("Sum = " + c);
                    break;
                case 2:
                    c = Math.Abs(a - b);
                    Console.WriteLine("Diffrence = " + c);
                    break;
                case 3:
                    c = a * b;
                    Console.WriteLine("Multipication =" + c);
                    break;
                case 4:
                    c = a / b;
                    Console.WriteLine("Division = " + c);
                    break;
                    default:
                    Console.WriteLine("Choose the Number between 1-4");
                        break;
            }

        }
    }
}
