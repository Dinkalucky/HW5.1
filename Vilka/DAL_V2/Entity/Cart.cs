using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_V2.Entity
{
    public class Cart
    {
        public Guid Id { get; set; }
        public User UsersUser { get; set; }
        public Product Product { get; set; }
    }
}
