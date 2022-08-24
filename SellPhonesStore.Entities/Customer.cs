﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhonesStore.Entities
{
    public class Customer
    {
        public long CustomerId { get; set; }
        [MaxLength(100)]
        [Required]
        public string CustomerName { get; set; }
        [Required]
        [EmailAddress]
        public string EmailId { get; set; }
        public string City { get; set; }
        public string StreetName { get; set; }
        public string PinCode { get; set; }
        public long MobileNo { get; set; }
        public List<CustomerOrder> Orders { get; set; } = new List<CustomerOrder>();
    }
}
