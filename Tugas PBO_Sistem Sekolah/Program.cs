using Tugas_PBO_Sistem_Sekolah;

class Program
{
    static void Main(string[] args)
    {
        // Membuat sekolah
        Sekolah sekolah = new Sekolah();

        // Membuat objek
        Siswa siswa = new Siswa("Budi", 15, "10 IPA");
        Guru guru = new Guru("Pak Darto", 40, "Sejarah");

        SiswaSD siswaSD = new SiswaSD("Rina", 10, "5A");
        SiswaSMA siswaSMA = new SiswaSMA("Andi", 17, "12 IPA");

        GuruMatematika guruMath = new GuruMatematika("Pak Budi", 45);
        GuruBahasa guruBahasa = new GuruBahasa("Bu Sinta", 38);

        // Tambah ke sekolah
        sekolah.TambahOrang(siswa);
        sekolah.TambahOrang(guru);
        sekolah.TambahOrang(siswaSD);
        sekolah.TambahOrang(siswaSMA);
        sekolah.TambahOrang(guruMath);
        sekolah.TambahOrang(guruBahasa);

        // Tampilkan data
        Console.WriteLine("=== DAFTAR ORANG DI SEKOLAH ===");
        sekolah.DaftarOrang();

        // Pertanyaan 1
        Console.WriteLine("\n=== Aktivitas Guru & Siswa ===");
        siswa.Aktivitas();
        guru.Aktivitas();

        // Pertanyaan 2
        Console.WriteLine("\n=== Guru Matematika ===");
        guruMath.MengajarHitung();

        // Pertanyaan 3
        Console.WriteLine("\n=== Info Lengkap Guru Matematika ===");
        guruMath.InfoOrang();

        // Pertanyaan 4
        Console.WriteLine("\n=== Ujian Nasional ===");
        siswaSMA.UjianNasional();

        // Pertanyaan 5 - Polymorphism
        Console.WriteLine("\n=====");
        Orang orang = new SiswaSD("Doni", 11, "6B");
        orang.Aktivitas();

        // Method khusus
        Console.WriteLine("\n====");
        siswaSD.Main();
        guruBahasa.MengajarBahasa();

        Console.ReadLine();
    }
}