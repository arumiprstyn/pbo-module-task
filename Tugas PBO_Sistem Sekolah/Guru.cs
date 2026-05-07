using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_PBO_Sistem_Sekolah
{
    internal class Guru : Orang
    {
        public string MataPelajaran { get; set; }
        public Guru(string nama, int umur, string mataPelajaran) : base(nama, umur)
        {
            this.MataPelajaran = mataPelajaran;
        }
        public void Mengajar()
        {
            Console.WriteLine($"{Nama} sedang mengajar mata pelajaran {MataPelajaran}.");
        }
        public override void Aktivitas()
        {
            Console.WriteLine($"{Nama} sedang melakukan aktivitas sebagai guru.");
        }
        public override void InfoOrang()
        {
            Console.WriteLine($"Nama           : {Nama}");
            Console.WriteLine($"Umur           : {Umur}");
            Console.WriteLine($"Mata Pelajaran : {MataPelajaran}");
        }
    }
}
