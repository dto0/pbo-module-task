using System;

public class Hewan
{
    public string Nama;
    public int Umur;

    public Hewan(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
    }

    public virtual string Suara()
    {
        return "Suara";
    }

    public virtual string InfoHewan()
    {
        return $"Nama: {Nama}, Umur: {Umur} tahun";
    }
}

public class Mamalia : Hewan
{
    public int JumlahKaki;

    public Mamalia(string nama, int umur, int jumlahkaki) : base(nama, umur)
    {
        JumlahKaki = jumlahkaki;
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Jumlah Kaki: {JumlahKaki}";
    }

    public override string Suara()
    {
        return "Suara Mamalia";
    }
}

public class Reptil : Hewan
{
    public double PanjangTubuh;

    public Reptil(string nama, int umur, double panjangtubuh) : base(nama, umur)
    {
        PanjangTubuh = panjangtubuh;
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Panjang Tubuh: {PanjangTubuh} m";
    }

    public override string Suara()
    {
        return "Suara Reptil";
    }
}

public class Singa : Mamalia
{
    public Singa(string nama, int umur, int jumlahkaki) : base(nama, umur, jumlahkaki) { }

    public void Mengaum()
    {
        Console.WriteLine("Mengaum");
    }

    public override string Suara()
    {
        return "AURRMM";
    }
}

public class Gajah : Mamalia
{
    public Gajah(string nama, int umur, int jumlahkaki) : base(nama, umur, jumlahkaki) { }

    public override string Suara()
    {
        return "WRFREETTT";
    }
}

public class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangtubuh) : base(nama, umur, panjangtubuh) { }

    public void Merayap()
    {
        Console.WriteLine("Ular Merayap");
    }

    public override string Suara()
    {
        return "MENDESISSKSKKKSK";
    }
}

public class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangtubuh) : base(nama, umur, panjangtubuh) { }

    public override string Suara()
    {
        return "HGHRRKK";
    }
}

public class KebunBinatang
{
    private List<Hewan> koleksihewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        koleksihewan.Add(hewan);
    }
}

class Program
{
    static void Main()
    {
        // Membuat objek kebun binatang
        KebunBinatang kebunBinatang = new KebunBinatang();

        // Membuat objek dari kelas Singa
        Singa singa = new Singa("SingaRimba", 8, 4);
        Console.WriteLine(singa.InfoHewan());
        Console.WriteLine();

        // Membuat objek dari kelas Gajah
        Gajah gajah = new Gajah("Gajahaha", 7, 4);
        Console.WriteLine(gajah.InfoHewan());
        Console.WriteLine("Suara: " + gajah.Suara());
        Console.WriteLine();

        // Membuat objek dari kelas Ular
        Ular ular = new Ular("Derik", 4, 2.55);
        Console.WriteLine(ular.InfoHewan());
        Console.WriteLine("Suara: " + ular.Suara());
        Console.WriteLine();

        // Membuat objek dari kelas Buaya
        Buaya buaya = new Buaya("Buara", 9, 3.3);
        Console.WriteLine(buaya.InfoHewan());
        Console.WriteLine("Suara: " + buaya.Suara());
        Console.WriteLine();

        // Membuat objek dari kelas Buaya untuk contoh
        Reptil reptil = new Buaya("Buatil", 4, 2.4);
        Console.WriteLine(reptil.InfoHewan());
        Console.WriteLine("Suara: " + reptil.Suara());
        Console.WriteLine();

        // Menambahkan hewan-hewan ke dalam kebun binatang
        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);
        kebunBinatang.TambahHewan(reptil);
    }
}
