namespace Wissen_C__Odev_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hiz = 60;
            Console.Write("Mesafeyi Giriniz (km): ");
            double mesafe = Convert.ToDouble(Console.ReadLine());
            double sure = mesafe / hiz;
            Console.WriteLine("Gidilebilecek Sure: " + sure + " saat");
        }
    }
}