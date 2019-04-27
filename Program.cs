using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsi
{
    class Program
    {
        static void Main(string[] args)
        {
            karyawan krywn = new karyawan();

            krywn.nama = "Arief";
            krywn.nik = "0126";
            krywn.gaji = 1000000;

            krywn.nama2 = "Kiky";
            krywn.nik2 = "0805";
            krywn.gaji2 = 2000000;

            krywn.infoGaji();
            Console.WriteLine();
            krywn.kenaikanGaji();
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
