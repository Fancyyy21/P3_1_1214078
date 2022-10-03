using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_1_1214078
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Buatlah program untuk menulis syair lagu "Anak Ayam" ciptaan AT Mahmud.
            Inputannya adalah anak ayam sejumlah N*/

            Console.WriteLine("==================");
            Console.WriteLine("ANAK AYAM TURUN 10");
            Console.WriteLine("==================");

            int angka = int.Parse(Console.ReadLine());
            if (angka > 10 || angka <= 0)
            {
                Console.WriteLine("==================");
                Console.WriteLine("Angka Tidak Sesuai");
                Console.WriteLine("==================");
            }
            else
            {
                for (int N = angka; N > 0; N--)
                {

                    if (N == 1)
                    {
                        Console.WriteLine("Anak ayam turunlah 1, mati satu tinggallah induknya");
                    }
                    else
                    {
                        Console.WriteLine("Anak ayam turunlah " + N + ", mati satu tinggallah " + (N - 1));
                    }
                }
            }      
        }
    }
}
