namespace Wissen_C__Odev_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Soru 2: Ekrandan 2 vize  bir final notu okutunuz. Vize ortalamasinin %30 u
                       finalin % 70 ni alip 50 ve uzerinde ise Gectiniz, Altinda ise kaldiniz mesaji veriniz. */

            Console.Write("1.Vize Notunuzu Giriniz: ");
            double vize1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2.Vize Notunuzu Giriniz: ");
            double vize2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Final Notunuzu Giriniz: ");
            double final = Convert.ToDouble(Console.ReadLine());
            double sonuc = (((vize1 + vize2) / 2) * 0.30) + (final * 0.70);
           
            if (vize1 < 0 || vize2 < 0 || final < 0 || vize1 > 100 || vize2 > 100 || final > 100)
            {
                Console.WriteLine("Yanlis Veri Girdiniz!");
            }
            else if (sonuc >= 50)
            {
                Console.WriteLine("Tebrikler Geçtiniz! Ortalamaniz: " + sonuc);
            }
            else if (sonuc < 50 && sonuc >= 0)
            {
                Console.WriteLine("Malesef Kaldiniz! Ortalamaniz: " + sonuc);
            }
        }
    }
}