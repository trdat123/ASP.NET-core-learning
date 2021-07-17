using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team_1_E_commerce.Models
{
    public class Cart
    {
        public int Id { get; set; }

        public string CartOwner { get; set; }

        public virtual List<CartProduct> CartProducts { get; set; }

    }
}
