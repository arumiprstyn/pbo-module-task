using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_PBO_Sistem_Sekolah
{
    internal class Orang
    {
        public string Nama { get; set; }
        public int Umur { get; set; }

        public Orang(string nama, int umur)
        {
            this.Nama = nama;
            this.Umur = umur;
        }
        public virtual void Aktivitas()
        {
            Console.WriteLine($"{Nama} sedang melakukan aktivitas.");
        }
        public void InfoOrang()
        {
            Console.WriteLine($"Nama: {Nama}");
            Console.WriteLine($"Umur: {Umur}");
        }
    }
}
