using System;
using System.Collections.Generic;

namespace Hafta5_Kapanis
{
    class Araba
    {
        public DateTime UretimTarihi { get; } // otomatik atanır
        public string SeriNumarasi { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }
        public int KapiSayisi { get; set; }

        public Araba()
        {
            UretimTarihi = DateTime.Now;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Araba> arabalar = new List<Araba>();

        // BAŞA DÖN: Kullanıcıya araba üretmek isteyip istemediğini sor
        Baslangic:
            Console.Write("Araba üretmek istiyor musunuz? (E/H): ");
            string cevap = Console.ReadLine().Trim().ToLower();

            if (cevap != "e" && cevap != "h" && cevap != "evet" && cevap != "hayır" && cevap != "hayir")
            {
                Console.WriteLine("Geçersiz cevap! Lütfen E(=Evet) veya H(=Hayır) giriniz.");
                goto Baslangic;
            }

            if (cevap == "h" || cevap == "hayır" || cevap == "hayir")
            {
                Console.WriteLine("Program sonlandırıldı.");
                return;
            }

        // Araba oluştur
        ArabaOlustur:
            Araba yeniAraba = new Araba();

            Console.Write("Seri Numarası: ");
            yeniAraba.SeriNumarasi = Console.ReadLine();

            Console.Write("Marka: ");
            yeniAraba.Marka = Console.ReadLine();

            Console.Write("Model: ");
            yeniAraba.Model = Console.ReadLine();

            Console.Write("Renk: ");
            yeniAraba.Renk = Console.ReadLine();

        KapisayisiTekrar:
            Console.Write("Kapı Sayısı: ");
            string kapiInput = Console.ReadLine();
            if (int.TryParse(kapiInput, out int kapiSayisi))
            {
                yeniAraba.KapiSayisi = kapiSayisi;
            }
            else
            {
                Console.WriteLine("Hatalı giriş! Lütfen kapı sayısını sayısal olarak giriniz.");
                goto KapisayisiTekrar;
            }

            arabalar.Add(yeniAraba);

            Console.Write("Başka araba üretmek istiyor musunuz? (E/H): ");
            string devam = Console.ReadLine().Trim().ToLower();
            if (devam == "e" || devam == "evet")
            {
                goto ArabaOlustur;
            }

            Console.WriteLine("\n=== Üretilen Arabalar ===");
            foreach (var araba in arabalar)
            {
                Console.WriteLine($"Seri No: {araba.SeriNumarasi} - Marka: {araba.Marka}");
            }

            Console.WriteLine("\nProgram sonlandı.");
        }
    }
}
