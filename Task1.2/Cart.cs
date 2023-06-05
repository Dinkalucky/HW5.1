using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5._2;

namespace Task1._2
{
    public class Cart
    {
        public Guid Id { get; set; }
        public User UsersUser { get; set; }
        public Product Product { get; set; }
    }
}
