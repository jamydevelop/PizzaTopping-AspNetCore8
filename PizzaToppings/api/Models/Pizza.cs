using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    [Table("Pizzas")]
    public class Pizza
    {
        public int id { get; set; }

        [Required]
        [MaxLength(100)]
        public string name { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal price { get; set; }

        public List<Topping> Toppings { get; set; } = new List<Topping>();
    }
}
