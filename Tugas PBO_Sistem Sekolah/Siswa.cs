using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_PBO_Sistem_Sekolah
{
    internal class Siswa : Orang
    {
        public string Kelas { get; set; }
        public Siswa(string nama, int umur, string kelas) : base(nama, umur)
        {
            this.Kelas = kelas;
        }
        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} sedang belajar di kelas {Kelas}.");
        }
    }
}
