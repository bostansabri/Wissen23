namespace Odev_8
{
    internal class Program
    {
        struct Employees
        {
            public int id;
            public string name;
            public string surName;
            public string department;
            public DateTime birthDay;
            public DateTime startWork;
            public string adress;
            public string city;
            public string state;
            public string postalCode;
            public string country;
            public string phoneNumber;
            public string education;
        }

        struct Customers
        {
            public string companySortName;
            public string companyName;
            public string personelName;
            public string department;
            public string adress;
            public string city;
            public string unKnown;
            public string postalCode;
            public string country;
            public string phoneNumber1;
            public string phoneNumber2;
        }
        static void Main(string[] args)
        {

            List<Employees> employees = new List<Employees>();
            int counter = 0;

            StreamReader sr = File.OpenText("D:\\Sabri Bostan\\Yazılım Kayıt Dosyaları\\C#\\Wissen23\\Odev 8\\Calisanlar.txt");

            while (!sr.EndOfStream)
            {
                string employee = sr.ReadLine();

                string[] data = employee.Split(';');
                Employees employees1 = new Employees();

                employees1.id = int.Parse(data[0]);
                employees1.name = data[1];
                employees1.surName = data[2];
                employees1.department = data[3];
                employees1.birthDay = DateTime.Parse(data[4]);
                employees1.startWork = DateTime.Parse(data[5]);
                employees1.adress = data[6];
                employees1.city = data[7];
                employees1.state = data[8];
                employees1.postalCode = data[9];
                employees1.country = data[10];
                employees1.phoneNumber = data[11];
                employees1.education = data[12];
                

                counter = employees1.id;
                employees.Add(employees1);
            }
            sr.Close();

            foreach (var item in employees)
            {
                Console.WriteLine(item.id + "\t" + item.name + "\t" + item.surName + "\t" + item.department + "\t" + item.birthDay + "\t" + item.startWork + "\t" + item.adress + "\t" + item.city + "\t" + item.state + "\t" + item.postalCode + "\t" + item.country + "\t" + item.phoneNumber + "\t" + item.education);
            }

            Console.WriteLine("--------------------------------------------------------------------------------");


            List<Customers> customers = new List<Customers>();

            StreamReader sr2 = File.OpenText("D:\\Sabri Bostan\\Yazılım Kayıt Dosyaları\\C#\\Wissen23\\Odev 8\\Musteriler.txt");

            while (!sr2.EndOfStream)
            {
                string customer = sr2.ReadLine();

                string[] data = customer.Split(";");
                Customers customers1 = new Customers();

                customers1.companySortName = data[0];
                customers1.companyName = data[1];
                customers1.personelName = data[2];
                customers1.department = data[3];
                customers1.adress = data[4];
                customers1.city = data[5];
                customers1.unKnown = data[6];
                customers1.postalCode = data[7];
                customers1.country = data[8];
                customers1.phoneNumber1 = data[9];
                customers1.phoneNumber2 = data[10];

                customers.Add(customers1);
            }
            sr.Close();

            foreach (var item in customers)
            {
                Console.WriteLine(item.companySortName + "\t" + item.companyName + "\t" + item.personelName + "\t" + item.department + "\t" + item.adress + "\t" + item.city + "\t" + item.unKnown + "\t" + item.postalCode + "\t" + item.country + "\t" + item.phoneNumber1 + "\t" + item.phoneNumber2);
            }
        }
    }
}