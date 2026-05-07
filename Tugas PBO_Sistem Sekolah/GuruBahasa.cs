using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_PBO_Sistem_Sekolah
{
    internal class GuruBahasa : Guru
    {
        public GuruBahasa(string nama, int umur) : base(nama, umur, "Bahasa")
        {
        }
        public void MengajarBahasa()
        {
            Console.WriteLine($"{Nama} sedang mengajar bahasa.");
        }
        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} sedang melakukan aktivitas sebagai guru bahasa.");
        }
    }
}
