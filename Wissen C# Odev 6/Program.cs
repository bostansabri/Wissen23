namespace Wissen_C__Odev_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Soru 6 : Klavyeden girilen 3 basamakli sayinin basamaklarini ekrana basaniniz

            Console.Write("Uc Basamakli Bir Sayi Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int birler = sayi / 100;
            int onlar = (sayi / 10) % 10;
            int yuzler = sayi % 10;
            Console.WriteLine("Birler Basamagi: " + birler + "\n" + "Onlar Basamagi: " + onlar + "\n" + "Yuzler Basamagi: " + yuzler);
        }
    }
}