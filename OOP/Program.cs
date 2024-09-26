using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo a = new PhanSo(1,2);
            PhanSo b = new PhanSo(1,2);
            //a.nhapPhanSo();
           // a.xuatPhanSo();
            //b.nhapPhanSo();
           // b.xuatPhanSo();

            PhanSo tmp = a.congPhanSo(a, b);

            tmp = tmp.rutGonPhanSo();
            
            Console.WriteLine("Phan so la: " + tmp.ToString());
            Console.ReadKey();



        }
    }
}
