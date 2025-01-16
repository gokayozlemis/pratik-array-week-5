using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] sayilar = new int[10];

        Console.WriteLine("Lütfen 10 adet tam sayı giriniz:");
        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.Write($"Sayı {i + 1}: ");
            sayilar[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nGirilen sayılar:");
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }

        Console.Write("\nBir sayı daha giriniz (11. eleman): ");
        int yeniSayi = int.Parse(Console.ReadLine());

        int[] yeniSayilar = new int[sayilar.Length + 1];
        for (int i = 0; i < sayilar.Length; i++)
        {
            yeniSayilar[i] = sayilar[i];
        }
        yeniSayilar[yeniSayilar.Length - 1] = yeniSayi;

        Array.Sort(yeniSayilar); //küçükten büyüye sıralama bu 
        Array.Reverse(yeniSayilar); //büyükten kücüğe cevirme bu 

        Console.WriteLine("\nBüyükten küçüğe sıralı dizi:");
        foreach (int sayi in yeniSayilar)
        {
            Console.WriteLine(sayi);
        }
    }
}
