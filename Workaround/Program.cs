using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {

            Degiskenler();
            SelamVer("Selman");
            SelamVer("Muharrem");
            SelamVer("YILMAZ");
            SelamVer();
            
            int sonuc = Topla(3,5);

            string ogrenci1 = "Engin";
            string ogrenci2 = "Berkay";
            string ogrenci3 = "Ayşe";

            Console.WriteLine(ogrenci1);
            Console.WriteLine(ogrenci2);
            Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Berkay";
            ogrenciler[2] = "Ayşe";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "İstanbul", "Ankara", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";

            Console.WriteLine(sehirler2[0]);


            Person person1 = new Person();
            person1.FirstName = "Muharrem";

            Person person2 = new Person();
            person2.FirstName = "Murat";

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler = new List<string> { "Ankara", "İstanbul", "İzmir"};
            yeniSehirler.Add("Kastamonu");

            foreach (var sehir in yeniSehirler)
            {
                Console.WriteLine(sehir);
            }


            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi2 = sayi1;
            //sayi1 = 30;
            //sayi2 = ??? //Sayı2 10 değerine sahip olur değer ve referans tip farkından dolayı.



            Console.ReadLine();
        }
        static void 
            Degiskenler()
        {
            string mesaj = "Merhaba";

            double tutar = 100000;
            int sayi = 100;
            bool girisYamismi = false;





            Console.WriteLine(mesaj);
            Console.WriteLine(tutar * 1.18);
            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);

            string Ad = "Muharrem Selman";
            string Soyad = "YILMAZ";
            int dogumYili = 1991;
            long tcNo = 17771234567;

        }

        //class Vatandas()
        //{
        //    public string Ad { get; set; }
        //    public string Soyad { get; set; }
        //    public int DogumYili { get; set; }
        //    public long TcNo { get; set; }
        //}

        static void SelamVer(string isim= "NoName")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10) { //İlk değer ataması yaparken default değer verilmeyecek olan parametre ilk olarak yazılır. Yani default parametreler en sona 
                                                          //yazılır.
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + sonuc);
            return sonuc;
                }
    }
}