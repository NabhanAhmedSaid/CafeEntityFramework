using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeEntityFramework
{
    public class Coffee
    {
        public int Id { get; set; }
        public string? CoffeeName { get; set; }
        public decimal Price { get; set; }
    }
}
