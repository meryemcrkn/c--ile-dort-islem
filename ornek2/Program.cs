using System;

namespace ornek2
{
    class Program
    {
        static int Main(string[] args)
        {
            int k, sifir_say = 0;
            float sonuc;
            int len = args.Length;
            if (len < 3)
            {
                Console.WriteLine("Eksik parametre");
                return 0;
            }
            string i = args[0];
            if (!(i == "t" || i == "ç" || i == "m" || i == "b"))
            {
                Console.WriteLine("Yanlış işlem!!!");
                return 0;
            }
            int[] sayilar = new int[len - 1];
            for (k = 0; k < (len - 1); k++)
            {
                sayilar[k] = Convert.ToInt32(args[k + 1]);
            }
            sonuc = sayilar[0];
            switch (i)
            {
                case "t":
                    for (k = 1; k < (len - 1); k++)
                        sonuc = sonuc + sayilar[k];
                    Console.WriteLine("Sonuç : {0} ", sonuc);
                    break;
                case "ç":
                    for (k = 1; k < (len - 1); k++)
                        sonuc = sonuc - sayilar[k];
                    Console.WriteLine("Sonuç : {0} ", sonuc);
                    break;
                case "m":
                    for (k = 1; k < (len - 1); k++)
                        sonuc = sonuc * sayilar[k];
                    Console.WriteLine("Sonuç : {0} ", sonuc);
                    break;
                case "b":
                    for (k = 1; k < (len - 1); k++)
                        if (sayilar[k] == 0)
                            sifir_say++;
                    switch (sifir_say)
                    {
                        case 0:
                            for (k = 1; k < (len - 1); k++)
                                sonuc = sonuc / sayilar[k];
                            Console.WriteLine("Sonuç : {0} ", sonuc);
                            break;
                        default:
                            Console.WriteLine("Bölenlerden biri sıfır olamaz.");
                            break;
                    }
                    break;


            }
            return 0;
        }
    }
}
