namespace Wissen_C__Odev_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Soru 5 : Ekrandan girilen 3 sayinin en buyugunu ve en kucugunu yazdirin.

            Console.WriteLine("3 Tane Sayi Giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > sayi2 && sayi1 > sayi3)
            {
                Console.WriteLine("En Buyuk Sayi: " + sayi1);
            }
            else if (sayi2 > sayi1 && sayi2 > sayi3)
            {
                Console.WriteLine("En Buyuk Sayi: " + sayi2);
            }
            else
            {
                Console.WriteLine("En Buyuk Sayi: " + sayi3);
            }
        }
    }
}