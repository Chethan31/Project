using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SellPhonesStore.Entities;

namespace SellPhonesStore.DataAccess
{
    public interface IPhoneRepository
    {
        long SavePhone(Phone phone);
        long SaveCustomer(Customer customer);
        long SaveOrder(CustomerOrder order);
        long SaveOrderedPhone(OrdereredPhone orderPhone, long orderId);
        List<CustomerOrder> GetCustomerOrders(long customerId);
        List<CustomerOrder> GetAllCustomerOrders();
    }
}
