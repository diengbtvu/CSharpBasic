using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trycatch
{
    class Program
    {

        static string ptb1(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    return "VSN";
                }else
                {
                    return "VN";
                }
            }else
            {
                return -b / (a) + "";
            }

        }
        static void Main(string[] args)


        {
            try
            {
                double a, b;
                Console.WriteLine("Nhap a: ");
                a = double.Parse(Console.ReadLine());

                Console.WriteLine("Nhap b: ");
                b = double.Parse(Console.ReadLine());


                Console.WriteLine("Ket qua phuong trinh " + a + "x + " + b + "= 0 la: " + ptb1(a, b));
                Console.ReadKey();



            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

            }
        }
    }
}
