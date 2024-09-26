using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class PhanSo
    {
        private double mauso;
        private double tuso;
        public PhanSo() { }
        public PhanSo(double a, double b)
        {
            this.mauso = b;
            this.tuso = a;
        }
        public double Mauso
        {
            get
            {
                return mauso;
            }

            set
            {
                mauso = value;
            }
        }
        public double Tuso
        {
            get
            {
                return tuso;
            }

            set
            {
                tuso = value;
            }
        }
        public void nhapPhanSo()
        {
            do
            {
                Console.WriteLine("Nhap tu so: ");
                Tuso = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap mau so: ");
                Mauso = double.Parse(Console.ReadLine());
            } while (Mauso == 0);
        }

        public void xuatPhanSo()
        {
            Console.WriteLine(Tuso + "/" + Mauso);
        }

        public PhanSo congPhanSo(PhanSo a, PhanSo b)
        {
            PhanSo tmp = new PhanSo();
            tmp.Tuso = a.Tuso * b.Mauso + b.Tuso * a.Mauso;
            tmp.Mauso = a.Mauso * b.Mauso;
            return tmp;
        }

        public override string ToString()
        {
            if (Mauso == 1) return Tuso + "";
            return Mauso + "/" + Tuso;
        }

        double gcd(double a, double b)
        {
            while (b != 0)
            {
                double temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public PhanSo rutGonPhanSo()
        {
            PhanSo tmp = new PhanSo();
            tmp.Tuso = Tuso;
            tmp.Mauso = Mauso;
            double uocChung = gcd(Tuso, Mauso);
            tmp.Tuso /= uocChung;
            tmp.Mauso /= uocChung;
            return tmp;
        }

    }
}
