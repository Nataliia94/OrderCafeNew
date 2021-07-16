using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderCafe.Models.DataBase
{
    public class Order
    {
        [Key]
        [Display(Name = "ClientName")]
        public string ClientName { get; set; }
        [Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }
        public PayMethodos PayMethodos { get; set; }

        [Display(Name = "FirstDish")]
        public string FirstDish { get; set; }
        [Display(Name = "SecondDish")]
        public string SecondDish { get; set; }
        public float Price { get; set; }
        public float Amount { get; set; }
        public float TotalPrice { get; set; }
    }
}
