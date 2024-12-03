using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KdvHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "KDV Hesaplama";

            Console.Write("Ürünün Fiyatı giriniz:");
            double fiyat = double.Parse(Console.ReadLine());

            Console.Write("KDV oranını giriniz:");
            double kdvOrani = double.Parse(Console.ReadLine());


            double kdvFiyat = fiyat * (1 + kdvOrani / 100);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Ürün Fiyatı={0}", fiyat);
            Console.WriteLine("Ürünün kdv'li fiyatı={0}", kdvFiyat);
            Console.ReadLine();
        }
    }
}
