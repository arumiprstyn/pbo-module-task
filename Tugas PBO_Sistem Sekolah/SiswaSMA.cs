using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_PBO_Sistem_Sekolah
{
    internal class SiswaSMA : Siswa
    {
        public SiswaSMA(string nama, int umur, string kelas) : base(nama, umur, kelas)
        {
        }
        public void UjianNasional()
        {
            Console.WriteLine($"{Nama} sedang belajar untuk ujian nasional.");
        }
        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} sedang belajar di kelas {Kelas} dan mempersiapkan ujian nasional.");
        }
    }
}
