using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdamHesapMakinası
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi1 = double.Parse(Console.ReadLine());
            for (int i = 0; i < 20; i++)// ardı ardına 20 işlem yapılabilinmesi için döngüyü 20 tekrara soktum
            {
                string islemIsareti = Console.ReadLine();// işlemişaretini char veritipiyle yapacaktım ama birden fazla karakter girildiğinde programın hata vermemesi için string kullandım
                if (islemIsareti == "+")
                {
                    double sayi2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Toplama(sayi1,sayi2));
                    sayi1 = Toplama(sayi1,sayi2);
                }
                else if (islemIsareti == "-" )
                {
                    double sayi2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Cıkarma(sayi1, sayi2));
                    sayi1 = Cıkarma(sayi1, sayi2);
                }
                else if (islemIsareti == "x")
                {
                    double sayi2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Carpma(sayi1, sayi2));
                    sayi1 = Carpma(sayi1, sayi2);
                }
                else if (islemIsareti == "/")
                {
                    double sayi2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Bolme(sayi1, sayi2));
                    sayi1 = Bolme(sayi1, sayi2);
                }
                else
                {
                    Console.WriteLine("Yanlış tuşlama yaptınız! Lütfen tekrar deneyin");
                    i = i + 21;// yanlış tuşlama yapıldığı taktirde döngüyü sonlandırması için i + 21 yaptım
                }
            }
            Console.ReadKey();
        }
        static double Toplama(double sayi1, double sayi2)
        {
            double sonuc;
            //double sayi2 = Convert.ToDouble(Console.ReadLine());
            sonuc = sayi1 + sayi2;
            //Console.WriteLine(sonuc);
            return sonuc;
        }
        static double Cıkarma(double sayi1, double sayi2)
        {
            double sonuc;
            //double sayi2 = Convert.ToDouble(Console.ReadLine());
            sonuc = sayi1 - sayi2;
            //Console.WriteLine(sonuc);
            return sonuc;
        }
        static double Carpma(double sayi1, double sayi2)
        {
            double sonuc;
            //double sayi2 = Convert.ToDouble(Console.ReadLine());
            sonuc = sayi1 * sayi2;
            //Console.WriteLine(sonuc);
            return sonuc;
        }
        static double Bolme(double sayi1, double sayi2)
        {
            double sonuc;
            //double sayi2 = Convert.ToDouble(Console.ReadLine());
            sonuc = sayi1 / sayi2;
            //Console.WriteLine(sonuc);
            return sonuc;
        }
    }
}
