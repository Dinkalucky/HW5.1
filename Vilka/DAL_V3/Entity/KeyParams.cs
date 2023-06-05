﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_V3.Entity
{
    public class KeyParams
    {
        [Key]
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public Word KeyWords { get; set; }
    }
}
