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
        [Key]
        public string FullClientName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public PayMethodos PayMethodos { get; set; }
        [Required]
        public string ComplexDish { get; set; }

        [Required]
        public float Price { get; set; }
        [Required]
        public float Amount { get; set; }
        [Required]
        public float TotalPrice { get; set; }
    }
}
