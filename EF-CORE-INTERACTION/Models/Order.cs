﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_INTERACTION.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string BookId { get; set; }

        public string UserId { get; set; }
    }
}
