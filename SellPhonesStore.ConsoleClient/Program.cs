using SellPhonesStore.DataAccess;
using SellPhonesStore.Entities;
namespace SellPhonesStore.ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //phone();
            //customer();
        }


        private static void phone()
        {
            Phone p= new Phone();
            Console.Write("Enter Phone Description:");
            p.PhoneDescription=Console.ReadLine();
            Console.Write("Enter Price:");
            p.Price=float.Parse(Console.ReadLine());
            Console.Write("Enter Brand Name:");
            p.BrandName=Console.ReadLine();
            Console.Write("Number of Stocks:");
            p.InStock=int.Parse(Console.ReadLine());
            p.ManufacturingDate=DateTime.Now;
            IPhoneRepository PR = new PhoneRepository();
            long id = PR.SavePhone(p);
            Console.WriteLine($"Phone has Saved in Id:{id}");
        }

        private static void customer()
        {
            Customer c = new Customer();
            Console.Write("Enter Customer Name:");
            c.CustomerName = Console.ReadLine();
            Console.Write("Enter Email ID:");
            c.EmailId = Console.ReadLine();
            Console.Write("Enter City:");
            c.City = Console.ReadLine();
            Console.Write("Enter Street Name:");
            c.StreetName = Console.ReadLine();
            Console.Write("Enter Pincode:");
            c.PinCode = Console.ReadLine();
            Console.Write("Enter Mobile Number:");
            c.MobileNo = long.Parse(Console.ReadLine());
            IPhoneRepository PR = new PhoneRepository();
            long id = PR.SaveCustomer(c);
            Console.WriteLine($"Customer has Saved in Id:{id}");
        }
    }
}