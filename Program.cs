namespace Wissen_C__Odev_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Soru 3: Ekrandan fiat ve adet bilgisini aliniz. %18 kdv + %20 OTV 'yi hesaplayip 
                       Devlete aktarilacak tutari hesaplayiniz. Vatandasin cebinden cikacak toplam tutari hesaplayiniz */

            Console.Write("Arac Fiyatini Giriniz (TL): ");
            int aracFiyat = Convert.ToInt32(Console.ReadLine());
            Console.Write("Arac Adetini Giriniz: ");
            int aracAdet = Convert.ToInt32(Console.ReadLine());
            double kdv = (aracFiyat * aracAdet) * 0.18;
            double otv = (aracFiyat * aracAdet) * 0.2;
            double devletAlacak = kdv + otv;
            double toplam = devletAlacak + aracFiyat * aracAdet;
            Console.WriteLine("Devlete Aktarilacak Olan Tutar (TL): " + devletAlacak);
            Console.WriteLine("Toplam Odenecek Tutar (TL): " + toplam);
        }
    }
}