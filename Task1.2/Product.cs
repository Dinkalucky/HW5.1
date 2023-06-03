using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._2
{
    public class Product
    {
        [Column("ProductId")]
        public Guid Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public double Cost { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        public int Quantity { get; set; }
        public Guid ProductAlterId { get; set; }

    }
}
