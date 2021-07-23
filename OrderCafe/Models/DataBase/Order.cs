using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrderCafe.Models.DataBase
{
    public class Order
    {
        [Required] 
        public string ClientName { get; set; }
        [Required]   
        public string PhoneNumber { get; set; }
        public PayMethodos PayMethodos { get; set; }


       
        public string FirstDish { get; set; }

      
        public string SecondDish { get; set; }
        public float Price { get; set; }
        public float Amount { get; set; }
        public float TotalPrice { get; set; }
    }
}
