using Tugas_PBO_Sistem_Sekolah;

class Program
{
    static void Main(string[] args)
    {
        // Membuat objek sekolah
        Sekolah sekolah = new Sekolah();

        // Membuat objek orang
        SiswaSD siswaSD = new SiswaSD("Budi", 10, "5A");
        SiswaSMA siswaSMA = new SiswaSMA("Andi", 17, "12 IPA");
        GuruMatematika guruMath = new GuruMatematika("Pak Darto", 40);
        GuruBahasa guruBahasa = new GuruBahasa("Bu Sinta", 35);

        // Menambahkan ke sekolah
        sekolah.TambahOrang(siswaSD);
        sekolah.TambahOrang(siswaSMA);
        sekolah.TambahOrang(guruMath);
        sekolah.TambahOrang(guruBahasa);

        // Menampilkan semua data
        sekolah.DaftarOrang();

        // Demonstrasi polymorphism

        List<Orang> orangList = new List<Orang>()
        {
                siswaSD,
                siswaSMA,
                guruMath,
                guruBahasa
            };

        foreach (Orang o in orangList)
        {
            o.Aktivitas();
        }

        // Memanggil method khusus
        Console.WriteLine();
        siswaSD.Main();
        siswaSMA.UjianNasional();
        guruMath.MengajarMatematika();
        guruBahasa.MengajarBahasa();
    }
}