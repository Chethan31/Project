using SellPhonesStore.DataAccess;
using SellPhonesStore.Entities;
namespace SellPhonesStore.ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            phone();
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
    }
}