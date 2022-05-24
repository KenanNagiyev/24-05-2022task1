using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public bool Isfront { get; set; }
        public bool IsBack { get; set; }
        public int ProductId { get; set; }
    }
}
