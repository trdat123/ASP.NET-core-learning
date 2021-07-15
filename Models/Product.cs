using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Team_1_E_commerce.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Model Name")]
        [Required]
        public string ModelName { get; set; }
        
        [DisplayName("Image Name")]
        [Required]
        public string Image { get; set; }

        [NotMapped]
        [DisplayName("Image File")]
        [Required]
        public IFormFile ImageFile { get; set; }
        public int Price { get; set; }
        
        [DisplayName("Version")]
        [Required]
        public string ModelType { get; set; }

        [Required]
        public int Quantity { get; set; }

        //Navigation Properties
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
