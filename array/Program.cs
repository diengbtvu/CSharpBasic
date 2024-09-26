using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            int N = int.Parse(Console.ReadLine());
            arr = new int[N];
            for(int i=0; i < arr.Length; i++)
            {
                Console.Write("Nhap ARR[" + i + "] :");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);
            Console.Write("Array sorted: ");
            foreach (int it in arr){
                Console.Write( it+" " );
            }
            Console.WriteLine("Max in array: "+ arr[arr.Length-1]);
            Console.ReadKey();
        }
    }
}
