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
        public string ModelName { get; set; }
        
        [DisplayName("Image Name")]
        public string Image { get; set; }

        [NotMapped]
        [DisplayName("Image File")]
        public IFormFile ImageFile { get; set; }
        public int Price { get; set; }
        public string ModelType { get; set; }
    }
}
