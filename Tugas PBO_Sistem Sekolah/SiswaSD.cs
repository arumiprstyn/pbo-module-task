using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_PBO_Sistem_Sekolah
{
    internal class SiswaSD : Siswa
    {
        public SiswaSD(string nama, int umur, string kelas) : base(nama, umur, kelas)
        {
        }
        public void Main()
        {
            Console.WriteLine($"{Nama} sedang bermain di taman sekolah.");
        }
        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} sedang belajar di kelas {Kelas} dan bermain di taman sekolah.");
        }
    }
}
