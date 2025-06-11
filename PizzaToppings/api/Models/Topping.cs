using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    [Table("Toppings")]
    public class Topping
    {
        public int id { get; set; }

        [Required]
        [MaxLength(100)]
        public string name { get; set; } = string.Empty;

       public List<PizzaTopping> PizzaToppings { get; set; } = new();

    }
}