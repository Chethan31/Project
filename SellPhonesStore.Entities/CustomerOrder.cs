using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhonesStore.Entities
{
    public class CustomerOrder
    {
        [Key]
        public long OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        public float OrderTotal { get; set; }
        public List<OrdereredPhone> OrderedPhones { get; set; }=new List<OrdereredPhone>();
    }
}
