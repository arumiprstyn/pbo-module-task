using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_PBO_Sistem_Sekolah
{
    internal class GuruMatematika : Guru
    {
        public GuruMatematika(string nama, int umur) : base(nama, umur, "Matematika")
        {
        }
        public void MengajarHitung()
        {
            Console.WriteLine($"{Nama} sedang mengajar matematika.");
        }
        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} sedang melakukan aktivitas sebagai guru matematika.");
        }
    }
}
