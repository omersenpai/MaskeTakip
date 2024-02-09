// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using Entities.Concrete;
namespace Workspace
{

    public class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();


            SelamVer("Engin");
            SelamVer("ömer");
            SelamVer("ahmet");
            SelamVer();
            int sonuc = Topla(5,6);

            //Diziler 
            //string ogrenci1 = "Engin";
                
            //string ogrenci2 = "Kerem";

            //string ogrenci3 = "Berkay";

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";
            ogrenciler =new string[4];
            ogrenciler[3] = "İlker";

            for(int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);
            Console.WriteLine("*************");

            Person person1=new Person();
            person1.FirstName = "Ömer Tarık";
            person1.LastName = "Sargın";
            person1.DateOfBirthYear = 2001;
            person1.NationalIdentity = 123;



            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir); 
            }
            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Adana 1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);


            Console.ReadLine();
        }

        static void SelamVer(string isim=" isimsiz") //default deger atama
        {       //
                //
            Console.WriteLine("merhaba"+isim);
        }
        static int Topla(int sayi1,int sayi2) {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam: "+sonuc);
            return sonuc;
            
        }

    }
}
