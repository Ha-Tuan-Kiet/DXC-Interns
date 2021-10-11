using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjectWork.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItemNavigation = new HashSet<OrderItem>();
        }

        public int OrderId { get; set; }
        public int? Total { get; set; }
        public int? OrderItemId { get; set; }
        public string Customer { get; set; }

        public virtual OrderItem OrderItem { get; set; }
        public virtual ICollection<OrderItem> OrderItemNavigation { get; set; }
    }
}
