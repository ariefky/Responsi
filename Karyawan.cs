using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace responsi
{
    class karyawan
    {
        public string nama { get; set; }
        public string nik { get; set; }
        public int gaji { get; set; }
        public string nama2 { get; set; }
        public string nik2 { get; set; }
        public int gaji2 { get; set; }
        public void infoGaji()
        {
            Console.WriteLine("No\tNik\tNama\tGaji");
            Console.WriteLine("1\t{0}\t{1}\t{2}", nik, nama, gaji);
            Console.WriteLine("2\t{0}\t{1}\t{2}", nik2, nama2, gaji2);
        }
        public void kenaikanGaji()
        {
            if (gaji < 0)
            {
                gaji = 0;
            }
            else if (gaji2 < 0)
            {
                gaji2 = 0;
            }
            Console.WriteLine("asiikkk gaji naik 10%");
            Console.WriteLine("No\tNik\tNama\tGaji");
            Console.WriteLine("1\t{0}\t{1}\t{2}", nik, nama, gaji + (gaji * 0.1));
            Console.WriteLine("2\t{0}\t{1}\t{2}", nik2, nama2, gaji2 + (gaji2 * 0.1));
        }
    }
}