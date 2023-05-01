namespace Wissen_C__Odev_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Soru 7 : saatte 60 km hizla giden bir aracin ekrandan girilen mesafeyi kac saatte alacagini hesaplayin

            double hiz = 60;
            Console.Write("Mesafeyi Giriniz (km): ");
            double mesafe = Convert.ToDouble(Console.ReadLine());
            double sure = mesafe / hiz;
            Console.WriteLine("Gidilebilecek Sure: " + sure + " saat");
        }
    }
}