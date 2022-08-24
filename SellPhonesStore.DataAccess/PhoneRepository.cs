using SellPhonesStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhonesStore.DataAccess
{
    public class PhoneRepository : IPhoneRepository
    {
        public List<CustomerOrder> GetAllCustomerOrders()
        {
            List<CustomerOrder> orders = new List<CustomerOrder>();
            SellPhonesStoreDbContext db = new SellPhonesStoreDbContext();
            var result = from c in db.CustomOrders
                         select c;
            foreach (var order in result)
            {
                Console.WriteLine(order);
                orders.Add(order);
            }
            return orders;
        }

        public List<CustomerOrder> GetCustomerOrders(long customerId)
        {
            List<CustomerOrder> orders = new List<CustomerOrder>();
            SellPhonesStoreDbContext db = new SellPhonesStoreDbContext();
            var cus = (from cu in db.Customers
                      where cu.CustomerId == customerId
                      select cu).FirstOrDefault();
            var result = from c in db.CustomOrders
                         where c.Customer==cus
                         select c;
            foreach (var order in result)
            {
                Console.WriteLine(order);
                orders.Add(order);
            }
            return orders;
        }

        public long SaveCustomer(Customer customer)
        {
            SellPhonesStoreDbContext db = new SellPhonesStoreDbContext();
            db.Customers.Add(customer);
            db.SaveChanges();

            var id = (from c in db.Customers
                      where c.EmailId == customer.EmailId
                      select c.CustomerId).FirstOrDefault();

            return id;
        }

        public long SaveOrder(CustomerOrder order)
        {
            throw new NotImplementedException();
        }

        public long SaveOrderedPhone(OrdereredPhone orderPhone, long orderId)
        {
            throw new NotImplementedException();
        }

        public long SavePhone(Phone phone)
        {
            SellPhonesStoreDbContext db = new SellPhonesStoreDbContext();
            db.Phones.Add(phone);
            db.SaveChanges();

            var id = (from p in db.Phones
                     where p.ManufacturingDate == phone.ManufacturingDate
                     select p.PhoneId).FirstOrDefault();

            return id;
        }
    }
}
