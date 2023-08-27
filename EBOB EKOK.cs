using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2 sayının ebobunu ve ekokunu bulan program");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Lütfen a sayısını giriniz ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen b sayısını giriniz ");
            int b = Convert.ToInt32(Console.ReadLine());
            // 19-16 satırlar ve arasındakiler ekrana girilen sayıları2 harf içerisine aktarır
            int kucuk = 0;
            int buyuk = 0;
            
            if (a >b) 
            //eğer a sayısı b sayısından büyük ise sayıları a sayısını büyük b sayısını küçük diye tanımlar
            {
                 kucuk = b;
                 buyuk = a;
            }
            else 
            //değil ise b sayısı büyük a sayısı küçük olur
            {
                  buyuk = b;
                  kucuk = a;
            }
            int k = buyuk % kucuk;
          //k sayısı büyük olan sayının küçük olan sayıya bölünmesi sonucu arta kalan sayılardır
           basla:
            if (k!=0) 
              //eğer k sayısı sıfıra eşit değil ise büyük sayı , küçük sayı , k sayısı birbirine eşittir
            {
             buyuk = kucuk;
             kucuk = k;
             k = buyuk % kucuk;
                goto basla;
              //goto komudu sizi bu eğer ifadesine geri atar
            }
            else
//değil ise ekrana ebobu ve ekoku yazar sonra da klavyeden tuş girilmesini bekler
            {
                Console.WriteLine("EBOB :" + kucuk);
                Console.WriteLine("EKOK :" + (a*b)/kucuk);
                goto cikis;
            }
        cikis:
            Console.ReadKey();
            
            
        }
    }
}
