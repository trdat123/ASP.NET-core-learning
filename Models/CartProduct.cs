using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Team_1_E_commerce.Models
{
    public class CartProduct
    {
        public int Id { get; set; }

        public int CartId { get; set; }
        
        public int ProductId { get; set; }

        public Cart Cart { get; set; }
        public Product Product { get; set; }
    }
}
