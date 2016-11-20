using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GameStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        [Required(ErrorMessage="Будь ласка, ведіть своє ім'я")]
        public string Name { get; set; }

        [Required(ErrorMessage="Ви повиннні вказати хоча б одну адресу")]
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }

        [Required(ErrorMessage="Будь ласка, вкажіть місто, куди потрібно відправити замовлення")]
        public string City { get; set; }
        public bool GiftWrap { get; set; }
        public bool Dispatched { get; set; }
        public virtual List<OrderLine> OrderLines { get; set; }
    }

    public class OrderLine
    {
        public int OrderLineId { get; set; }
        public Order Order { get; set; }
        public Game Game { get; set; }
        public int Quantity { get; set; }
    }
}