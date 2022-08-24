using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhonesStore.Entities
{
    public class OrdereredPhone
    {
        [Key]
        public long OrderedPhoneId { get; set; }
        public Phone OrderedPhone { get; set; }
        [Range(0, float.MaxValue)]
        public float Quantity { get; set; }
    }
}
