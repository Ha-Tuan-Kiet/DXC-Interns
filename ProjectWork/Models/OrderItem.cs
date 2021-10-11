using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ProjectWork.Models
{
    public partial class OrderItem
    {
        public OrderItem()
        {
            Order = new HashSet<Order>();
        }

        public int OrderItemId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
        public int? SubTotal { get; set; }
        public int? OrderId { get; set; }

        public virtual Order OrderNavigation { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}
