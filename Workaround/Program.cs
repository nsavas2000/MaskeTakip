using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {


            Person person1 = new Person();
            person1.FirsName = "Engin";
            person1.LastName = "Demiroğ";
            person1.NationalIdentity = 123;
            person1.DateOfBirthDay = 1985;


            List<string> yeniSehirler1 = new List<string> {"Ankara", "Bursa", "İzmir" };


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);




            Console.ReadLine();


        }

        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }
        static int Topla(int sayi1, int sayi2=7)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);
            return sonuc;

        }

        

         


    }

   

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }
}
