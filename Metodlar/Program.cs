using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)

        {
            string UrunAdi = "Elma";
            double Fiyati = 15;
            string Aciklama = " Amasya Elmasi";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyati = 7;
            urun2.Aciklama = "Diyarbakir";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                {

                    Console.WriteLine("------metodlar-----");
                    SepetManager sepetmanager = new SepetManager();

                sepetmanager.Ekle(urun1);
               
                sepetmanager.Ekle(urun2);

                   



                }
            }
        }
    }
}

