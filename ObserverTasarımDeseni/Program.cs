using System;

namespace ObserverTasarımDeseni
{
    class Program
    {
        static void Main(string[] args)
        {
            BlogYazarı blogYazarı = new BlogYazarı();

            BlogOkuyucu okuyucu1 = new BlogOkuyucu("Ali");
            BlogOkuyucu okuyucu2 = new BlogOkuyucu("Ahmet");

            blogYazarı.OkuyucuEkle(okuyucu1);
            blogYazarı.OkuyucuEkle(okuyucu2);

            blogYazarı.OkuyucuyaBildir("  Observer Tasarım Deseni ile ilgili yeni bir blog yayınladım..!!");

            Console.WriteLine(Environment.NewLine);

            blogYazarı.OkuyucuyaBildir("  Yeni bir blog yayınladım..!!");

           
        }
    }
}
