using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas_PBO_Sistem_Sekolah
{
    class Sekolah
    {
        private List<Orang> daftarOrang = new List<Orang>();

        public void TambahOrang(Orang orang)
        {
            daftarOrang.Add(orang);
        }
        public void DaftarOrang()
        {
            Console.WriteLine("Daftar Orang di Sekolah:");
            foreach (var orang in daftarOrang)
            {
                Console.WriteLine("================================");
                orang.InfoOrang();
                orang.Aktivitas();
            }
        }
    }
}
