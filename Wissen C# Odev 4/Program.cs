namespace Wissen_C__Odev_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Soru 4: Bir fabrikada calisan işcilerin aile durumlarina gore ek maaş verilmektedir.
                       Cocuk sayisi 1 ise % 5, 2 ise % 10, 3 ve yukarisi ise % 30 verilmektedir.
                       Eger bekar ise % 10 kesinti yapilmaktadir. 
                       Buna gore kullanicidan işçi maaşi ve medeni durumu alinip cocuk sayisina göre maaş hesaplamasi yapiniz
            */

            Console.Write("Medeni Durumunuzu Giriniz (Evli/Bekar): ");
            string medeniDurum = Convert.ToString(Console.ReadLine());
            Console.Write("Maasinizi Giriniz (TL): ");
            double maas = Convert.ToDouble(Console.ReadLine());
            
            if (medeniDurum == "Evli")
            {
                
                Console.Write("Cocuk Sayinizi Giriniz (Yoksa 0 Yaziniz): ");
                int cocukSayisi = Convert.ToInt32(Console.ReadLine());
                
                if (cocukSayisi == 0)
                {
                    Console.WriteLine("Maasiniz: " + maas);
                }
                else if (cocukSayisi == 1)
                {
                    maas = (maas * 0.05) + maas;
                    Console.WriteLine("Maasiniz: " + maas);
                }
                else if (cocukSayisi == 2)
                {
                    maas = (maas * 0.1) + maas;
                    Console.WriteLine("Maasiniz: " + maas);
                }
                else if (cocukSayisi >= 3)
                {
                    maas = (maas * 0.3) + maas;
                    Console.WriteLine("Maasiniz: " + maas);
                }
                else
                {
                    Console.WriteLine("Yanlis Veri Girdiniz!");
                }

            }
            else if (medeniDurum == "Bekar")
            {
                Console.WriteLine("Maasiniz: " + maas);
            }
            else
            {
                Console.WriteLine("Yanlis Veri Girdiniz!");
            }
        }
    }
}