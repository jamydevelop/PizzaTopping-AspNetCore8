using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    [Table("PizzasToppings")]
    public class PizzaTopping
    {
        public int PizzaId { get; set; }

        public Pizza Pizza { get; set; }

        public int ToppingId { get; set; }
        public Topping Topping { get; set; }
    }
}