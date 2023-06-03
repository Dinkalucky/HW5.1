using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1._2.Enum;

namespace Task1._2
{
    public class Error
    {
        [MaxLength(200)]
        public string Message { get; set; }
        [Column(TypeName = "Date")]
        public DateTime Time { get; set; }
        [MaxLength(100)]
        public string Request { get; set; }
        public StatusCode Status { get; set; }
    }
}
