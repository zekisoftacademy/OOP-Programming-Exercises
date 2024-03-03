using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Methods
{
    class Program
    {
        #region Metot1
        //static void Main(string[] args)
        //{
        //    int a, b, c, d;
        //    int sonuc = 0;

        //    a = 5;
        //    b = 3;
        //    sonuc = a + b;
        //    Console.WriteLine($" {a} + {b} = {sonuc}");
        //    MesajGoster();
        //    Console.ReadKey();
        //}

        //static void MesajGoster()
        //{
        //    Console.WriteLine("İşlem Tamamlandı");
        //    Console.WriteLine("Bu İşlem Zeki SERT Tarafından Yapıldı");
        //    Console.WriteLine("Tamamlanma Zamanı : " + DateTime.Now.ToShortTimeString());
        //} 
        #endregion

        #region Metot2
        //static void Main(string[] args)
        //{
        //    int a, b, c, d;
        //    int sonuc = 0;

        //    a = 5;
        //    b = 3;
        //    sonuc = EkleOperasyonu(a, b);
        //    Console.WriteLine($" {a} + {b} = {sonuc}");
        //    MesajGoster();

        //    c = 15;
        //    d = 10;
        //    sonuc = EkleOperasyonu(c, d);
        //    Console.WriteLine($" {c} + {d} = {sonuc}");
        //    MesajGoster();
        //    Console.ReadKey();
        //}
        //static int EkleOperasyonu(int x, int y)
        //{
        //    int sonuc = 0;
        //    sonuc = x + y;
        //    return sonuc;
        //}
        //static void MesajGoster()
        //{
        //    Console.WriteLine("İşlem Tamamlandı");
        //    Console.WriteLine("Bu İşlem Zeki SERT Tarafından Yapıldı");
        //    Console.WriteLine("Tamamlanma Zamanı : " + DateTime.Now.ToShortTimeString());
        //} 
        #endregion

        static void Main(string[] args)
        {
            GetName();
            Console.ReadLine();
        }
        static void GetName()
        {
            string name = string.Empty;
            name = Console.ReadLine();
            Merhaba(name);
        }
        static void Merhaba(string name)
        {
            Console.WriteLine($"Hoşgeldiniz, {name}");
        }
    }
}
