using System;
using System.Diagnostics.Tracing;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        Laptop laptop1 = new Laptop("Advan", "WorkPlus", "24", "512", "Intel 5");
        Earphonewireless Earphonewireless1 = new Earphonewireless("Sony", "WF-1000XM4", "Biru", 5000);

        laptop1.Cetakinformasi();
        laptop1.Sambungkan();
        laptop1.Putuskan();

        Earphonewireless1.Cetakinformasi();
        Earphonewireless1.Sambungkan();
        Earphonewireless1.Putuskan();
    }
}

abstract class Elektronik
{
    public string merk;
    public string model;

    public Elektronik(string merk, string model)
    {
        this.merk = merk;
        this.model = model;
    }
    public abstract void Hidupkan();

    public abstract void Cetakinformasi();
    public void Matikan()
    {
        Console.WriteLine("Elektronik dimatikan.");
    }
}

interface IisiDaya
{
    void Sambungkan();
    void Putuskan();
}

class Laptop : Elektronik, IisiDaya
{
    public string ram;
    public string penyimpanan;
    public string prosesor;

    public Laptop(string merk, string model, string ram, string penyimpanan, string prosesor) : base(merk, model)
    {
        this.ram = ram;
        this.penyimpanan = penyimpanan;
        this.prosesor = prosesor;
    }

    public override void Hidupkan()
    {
        Console.WriteLine("Laptop Berhasil Dihidupkan\n");
    }
    public override void Cetakinformasi()
    {
        Console.WriteLine($"Model\t: {model}\nMerk\t: {merk}\nRam\t: {ram}\nPenyimpanan\t: {penyimpanan}\nProsesor\t: {prosesor}\n");
    }

    public void Sambungkan()
    {
        Console.WriteLine("isi daya laptop tersambung\n");
    }
    public void Putuskan()
    {
        Console.WriteLine("isi daya laptop terputus\n");
    }
}

class Earphonewireless : Elektronik, IisiDaya
{
    public string warna;
    public float baterai;

    public Earphonewireless(string merk, string model, string warna, float baterai) : base(merk, model)
    {
        this.baterai = baterai;
        this.warna = warna;
    }

    public override void Hidupkan()
    {
        Console.WriteLine("Earphonewireless Berhasil Dihidupkan");
    }
    public override void Cetakinformasi()
    {
        Console.WriteLine($"Model\t: {model}\nMerk\t: {merk}\nWarna\t: {warna}\nKapasitas Baterai : {baterai} watt\n");
    }

    public void Sambungkan()
    {
        Console.WriteLine("isi daya Earphonewireless tersambung\n");
    }
    public void Putuskan()
    {
        Console.WriteLine("isi daya Earphonewireless terputus\n");

    }
}